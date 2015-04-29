using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Template.DomainInterface.Enums;

namespace Template.DomainInterface
{
    public interface IItemGetList<I>
    {
        /// <summary>
        /// Returns Generic List of Entity-Types that have common properties like id, text and description
		/// unlike IEntityTypeGetter which is bound by enum, this factory is not bound by enum
        /// Filters by type of T
        /// </summary>
        /// <typeparam name="T">type T of Entity-Type</typeparam>
        /// <returns>List of Entity Types</returns>
        List<I> GetList<T>() where T : I ;
    }
}
