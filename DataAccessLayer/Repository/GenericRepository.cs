using Template.DataAccessLayer.Reository;


namespace Template.Data.Repository
{
    using System;
    using System.CodeDom;
    using System.Collections;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Linq.Expressions;
    using AutoMapper;
    using Template.Business.Interface.Domain;
    using Template.Business.Interface.Repository;

    

    /// <summary>
    /// The generic repository.
    /// </summary>
    /// <typeparam name="TObject">
    /// Where type is class
    /// </typeparam>
    public class GenericRepository<TObject> : IRepository<TObject> where TObject : class, IDomainObject
    {

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
           
        }

        private object somethingInjected;

        public GenericRepository(object somethingInjected)
        {
            this.somethingInjected = somethingInjected;
            this.SetUp();
        }

        private void SetUp()
        {

        }

        public TObject Get(object id)
        {
            object dataSet = null;
            TObject domainObjects = null;
            var query = Mapper.Map(dataSet, domainObjects);
            return query;
        }


        public virtual IEnumerable<TObject> Get(
            Expression<Func<TObject, bool>> filter = null,
            Func<IQueryable<TObject>, IOrderedQueryable<TObject>> orderBy = null,
            string includeProperties = "")
        {

            IQueryable<TObject> query = null;

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
           
        }

        public virtual void Delete(object id)
        {
            
        }

        /// <summary>
        /// The update.
        /// </summary>
        /// <param name="domObject">
        /// The entity to update.
        /// </param>
        public virtual void Update(TObject domObject)
        {
           
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
                    somethingInjected = null;
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
            return 1;
        }

        /// <summary>The get mapped database set.</summary>
        /// <param name="t">The t.</param>
        /// <returns>The <see cref="Type"/> type that is mapped with the domain object.</returns>
        private Type GetMappedDBSet(Type t)
        {
            // Move all the mappings to one mapping one
            if (t == typeof(IAddress))
            {
                return typeof(Address);
            }
           
            return null;
        }
    }
}