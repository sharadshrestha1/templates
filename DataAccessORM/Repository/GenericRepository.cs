namespace Template.Data.ORM.Repository
{
    using System;
    using System.CodeDom;
    using System.Collections;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Linq.Expressions;
    using AutoMapper;

    using Template.Business.Domain;

    using dto=Template.Business.DTO;
    using Template.Business.Interface.Domain;
    using Template.Business.Interface.Repository;
    using Template.DomainInterface.DTO;

    /// <summary>
    /// The generic repository.
    /// </summary>
    /// <typeparam name="TObject">
    /// Where type is class
    /// </typeparam>
    public class GenericRepository<TObject> : IRepository<TObject> where TObject :  class, IDomainDto
    {
        internal DbContext context;
        internal DbSet dbSet;
        private Type currentDbType;

        private bool _disposed;

        /// <summary>
        /// Generic Repository is usefuly only when doing simple CRUD operations. The entity passed in has to include 
        /// Initializes a new instance of the <see cref="GenericRepository{TObject}"/> class.
        /// </summary>
        /// <param name="context">
        /// The context.
        /// </param>
        public GenericRepository()
        {
            if (this.context == null)
            {
                this.context = new HFBDataContext();
            }

            this.SetUp();
        }


        public GenericRepository(DbContext dbContext)
        {
            this.context = dbContext;
            this.SetUp();
        }

        private void SetUp()
        {
            this.currentDbType = this.GetMappedDBSet(typeof(TObject));

            // entity to domain
            Mapper.CreateMap(this.currentDbType.UnderlyingSystemType, typeof(TObject).UnderlyingSystemType);

            // domain to entity
            Mapper.CreateMap(typeof(TObject).UnderlyingSystemType, this.currentDbType.UnderlyingSystemType);

            this.dbSet = this.context.Set(this.currentDbType);
        }

        public TObject Get(object id)
        {
            var entity = this.dbSet.Find(id);

            //Mapper.CreateMap(entity.GetType(), typeof(TObject));

           // Mapper.CreateMap(typeof(State), typeof(domain.State));
            //Mapper.CreateMap(typeof(domain.State), typeof(State));

            //var de = new domain.State();

            //object o = Mapper.Map<domain.State>(entity);


            //object destination = Mapper.Map(entity, entity.GetType(), typeof(TObject));
            
            return Mapper.Map<TObject>(entity);
            //return (TObject)destination;
        }


        public virtual IEnumerable<TObject> Get(
            Expression<Func<TObject, bool>> filter = null,
            Func<IQueryable<TObject>, IOrderedQueryable<TObject>> orderBy = null,
            string includeProperties = "")
        {
            IQueryable<TObject> query = (IQueryable<TObject>)dbSet.AsQueryable();

            if (filter != null)
            {
                // Refactor: using expression builder, create a where clause for generic types (if possible)
                //this.dbSet.Find()
                //query = query.w
            }

            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }
            else
            {
                return query.ToList();
            }
        }


        public virtual void Insert(TObject domObject)
        {
            var entity = Activator.CreateInstance(this.currentDbType);

            // domain to entity
            Mapper.Map(domObject, entity, domObject.GetType(), entity.GetType());
            this.dbSet.Add(entity);
        }

        public virtual void Delete(object id)
        {
            var entity = this.dbSet.Find(id);
            dbSet.Remove(entity);
        }

        /// <summary>
        /// The update.
        /// </summary>
        /// <param name="domObject">
        /// The entity to update.
        /// </param>
        public virtual void Update(TObject domObject)
        {
            var entity = this.dbSet.Find(domObject.Id);

            // domain to entity
            Mapper.Map(domObject, entity, domObject.GetType(), entity.GetType());

            this.dbSet.Attach(entity);
            this.context.Entry(entity).State = EntityState.Modified;
        }


        /// <summary>
        /// The dispose.
        /// </summary>
        /// <param name="disposing">
        /// The disposing.
        /// </param>
        public virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    this.context.Dispose();
                }
            }

            this._disposed = true;
        }

        /// <summary>
        ///     The dispose.
        /// </summary>
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>The save changes.</summary>
        /// <returns>The <see cref="int"/>. integer value after save change is completed</returns>
        public virtual int SaveChanges()
        {
            return this.context.SaveChanges();
        }

        /// <summary>The get mapped database set.</summary>
        /// <param name="t">The t.</param>
        /// <returns>The <see cref="Type"/> type that is mapped with the domain object.</returns>
        private Type GetMappedDBSet(Type t)
        {
            // Move all the mappings to one mapping one
            if (t == typeof(dto.AddressDto))
            {
                return typeof(Location);
            }
            else if (t == typeof(dto.StateDto))
            {
                return typeof(State);
            }
            return null;
        }
    }
}