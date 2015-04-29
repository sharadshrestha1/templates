using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using Template.DomainInterface;
using Template.DomainInterface.Enums;

namespace Template.Business
{
    /// <summary>
    /// BasseEntityList class for getting entity types that have common feature like id, text and description
	/// Handy when blinding to  drop down or controls that uses ListItems
    /// </summary>
    [Serializable]
    public class BaseListClass: IItemList
    {
        //Only `ctor for base class to inforce derived class have the same signature
		protected BaseListClass(int id, string text, string description)
        {
            ID = id;
            Text = text;
            Description = description;
        }

        //static method in base class that will be used by derived class. This piece of code can stay in static
        //static ListAll for derived class but this will eliminate the need to repeat the same code
        protected static IItemGetList<IItemList> GetListManager()
        {
            var container = GenericSingleton<ComponentContainer>.GetInstance().Container;
			return container.Resolve<IItemGetList<IItemList>>("itemGetList");
        }

        // Defining these properities in base class ensures all inherited classes have these properties
        // Marked virtual so that they can be overriden if necessary
        /// <summary>
        /// Description of the Entity Type
        /// </summary>
        public virtual string Description { get; protected  set; }
        /// <summary>
        /// ID of the Entity Type
        /// </summary>
        public virtual int ID { get; protected set; }
        /// <summary>
        /// Text of the Entity Type
        /// </summary>
        public virtual string Text { get; protected set; }
    }
}
