using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Template.DomainInterface;

using Template.DomainInterface.Enums;

namespace Template.Business
{
    public class PhoneType // : BaseEntityType
    {
		public int phoneTypeId { get; set; }
		public string description { get; set; }
		public enmPhoneTypes phoneType { get; set; }

		//public override IList<BaseEntityType> GetList()
		//{
		//	return ListGetter.GetEntityType(enmEntityTypes.PhoneType);
		//}

		//public override int ID
		//{
		//	get { return this.phoneTypeId; }
		//}

		//public override string DisplayText
		//{
		//	get { return string.Format("{0} - {1}", "phone is ", this.description); }
		//}


    }
}
