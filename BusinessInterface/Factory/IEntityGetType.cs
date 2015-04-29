using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Template.DomainInterface.Enums;

namespace Template.DomainInterface
{

	/// <summary>
	/// Interface for gettling a list of Entity Types
	/// </summary>
	/// <typeparam name="T"></typeparam>
    public interface IEntityGetTypes<T>
    {
		/// <summary>
		/// This GetList is bound by enmEntityTypes so any time a new entity type is added, enum has to be 
		/// modified
		/// </summary>
		/// <param name="entityType"></param>
		/// <returns></returns>
        IList<T> GetEntityType(enmEntityTypes? entityType);
    }
}
