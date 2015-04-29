using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;

using Template.Business.Interface.Domain;

namespace Template.Business.Interface.Repository
{
	/// <summary>
	/// Repository Interface. CRUD will have to be implemented if inhereting this interface
	/// </summary>
	/// <typeparam name="T"></typeparam>
    public interface IRepository<TDtoObject> where TDtoObject : class
    {
        TDtoObject Get(object id);

        IEnumerable<TDtoObject> Get(
            Expression<Func<TDtoObject, bool>> filter = null,
            Func<IQueryable<TDtoObject>, IOrderedQueryable<TDtoObject>> orderBy = null,
            string includeProperties = "");

        void Insert(TDtoObject domObject);

        void Delete(object id);

        /// <summary>
        /// The update.
        /// </summary>
        /// <param name="domObject">
        /// The entity to update.
        /// </param>
        void Update(TDtoObject domObject);

        /// <summary>The save changes.</summary>
        /// <returns>The <see cref="int"/>. integer value after save change is completed</returns>
        int SaveChanges();
    }
}
