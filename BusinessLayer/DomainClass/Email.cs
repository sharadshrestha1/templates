using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;


using Template.Utilities;
using Template.DomainInterface;



using Template.Business.Interface.Repository;
using Template.Business.Interface.Domain;

namespace Template.Business
{
    [Serializable]
    public class Email // : DomainBase, IEmail, IDomainObject
    {
         protected internal Email()
         {
                
         }
        //public override int BusinessEntityID
        //{
        //    get { return emailId; }
        //}


        #region IEmail Members

        public int emailId { get; set; }
        public string emailAddress { get; set; }
        public int? customerId { get; set; }

        #endregion
    }
}
