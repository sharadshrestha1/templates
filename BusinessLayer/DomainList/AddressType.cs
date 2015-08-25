using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Template.DomainInterface;

using Template.DomainInterface.Enums;

namespace Template.Business
{
    public class AddressType : BaseEntityType
    {
		public int addressTypeId { get; set; }
		public string description { get; set; }

		public override IList<BaseEntityType> GetList()
		{
            return null; // ListGetter.GetEntityType(enmEntityTypes.AddressType);
		}

		public override int ID
		{
			get { return this.addressTypeId; }
		}

		public override string DisplayText
		{
			get { return string.Format("{0} - {1}", "address is ", this.description); }
		}
    }
}
