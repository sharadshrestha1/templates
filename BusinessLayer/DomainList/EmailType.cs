using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using Template.DomainInterface;
using Template.DomainInterface.Enums;

namespace Template.Business
{
    public class EmailType: BaseEntityType
    {
        public int emailTypeId { get; set; }
        public string description { get; set; }

		public override IList<BaseEntityType> GetList()
        {
            return null; // ListGetter.GetEntityType(enmEntityTypes.EmailType);
        }

        public override int ID
        {
			get { return this.emailTypeId; }
        }

        public override string DisplayText
        {
            get { return string.Format("{0} - {1}", "email is ", this.description); }
        }
    }
}
