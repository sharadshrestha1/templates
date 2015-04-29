using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Template.DomainInterface;
using Microsoft.Practices.Unity;
using Template.Utilities;


using Template.Business.Interface.Repository;
using Template.Business.Interface.Domain;
using Template.ValidationMessaging;

namespace Template.Business
{
    [Serializable]
    public class Customer //: DomainBase, ICustomer
    {
        //public override IRepository<DomainBase> Repository { get; set; }
        //protected internal Customer(IRepository<Customer> repository)
        //{
        //    this.Repository = (IRepository<DomainBase>)repository;
        //}

   
        public override object Id
        {
            get { return customerId; }
        }


        # region ICustomer

		public int customerId { get; set; }
		
		public string customerNumber { get; set; }
        
        public string firstName { get; set; }
        
        public string lastName { get; set; }
        
		public char? middleInitial { get; set; }

		public DateTime? birthDate { get; set; }

		public string occupation { get; set; }
        
        public string SSN { get; set; }
        
		public string suffix { get; set; }
        
		public string title { get; set; }
       
		public IList<IPhone> PhoneList { get; set; }
        public IList<IAddress> AddressList { get; set; }
        public IList<IEmail> EmailList { get; set; }
        
		#endregion


        public override IValidationResult Validate()
        {
            throw new NotImplementedException();
        }
    }
}
