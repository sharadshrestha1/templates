using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Template.DomainInterface;
using Template.DomainInterface.Enums;

namespace Template.Business
{
    public class YesNoDefault: BaseListClass
    {
		/// <summary>
        /// constructor signature enforced by inheritance.
		/// base property is populated at the creation of the class
        /// </summary>
        /// <param name="id">int ID for the object</param>
        /// <param name="text">string Text </param>
        /// <param name="description">string Description</param>
		public YesNoDefault(int id, string text, string description) : base(id, text, description)
        {

		}

        #region IItemList Members

        public IList<IItemList> GetYNList()
        {
            //Creating of the YesNoDefault can be moved to Datalayer or database
            IList<IItemList> list = new List<YesNoDefault>().Cast<IItemList>().ToList();
            
			list.Add(new YesNoDefault(ID= 1, Text="y", Description="Yes"));
            list.Add(new YesNoDefault(ID= 2, Text="n", Description="No"));
            list.Add(new YesNoDefault(ID= 3, Text="d", Description="Default"));
            
			return list;
        }

        public static List<IItemList> GetList()
        {
			return BaseListClass.GetListManager().GetList<YesNoDefault>();
        }


        #endregion


    }
}
