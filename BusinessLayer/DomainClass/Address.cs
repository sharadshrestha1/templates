using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



using Template.Utilities;
using Template.DomainInterface;


using Template.Business.Interface.Repository;
using Template.Business.Interface.Domain;


namespace Template.Business.Domain
{
    using Template.Busines.Interface.Utility;
    using Template.Business.DTO;
    using Template.DomainInterface.DTO;

    [Serializable]
    public class Address : DomainBase<AddressDto>, IAddress, IUserStampApplied
    {
        public IUserTimeStamp UserChangeStamp { get; protected set; }

        public IAddressDto AddressDto {
            get
            {
                return (IAddressDto)base.dto;
            }
            set
            {
                base.dto = (AddressDto)value;
            }
        }

        internal Address(IRepository<AddressDto> repository, AddressDto addressDto)
            : base(repository, addressDto)
        {
            
        }

        internal Address()
        {
             
        }


        # region IAddress

        public int addressId { get; set; }

        public int? AddressModeID { get; set; }
        
		/// <summary>
		/// This attribute required this field not to be valid
		/// </summary>
		
        public int? addressTypeId { get; set; } 
		//SE NOTE: but the int is nullable. Could have made to int type and creating
		// an attribute that says ZeroNotValid or something. YUDBA
		
		
        public string addressLine1 { get; set; }

        public string addressLine2 { get; set; }
        
		
        public string city { get; set; }
        
		
        public string state { get; set; }
        
		
        
        public string zipCode { get; set; }
        
		public string zipCodePlus { get; set; }

        public int? customerId { get; set; }


        #endregion
      
        #region other properties
      

        public bool IsPrimaryAddress
        {
            get
            {
                //Business Rule: AddressCodeId 0 is primary
                return (AddressModeID.HasValue && AddressModeID.Value == 0);
            }
        }

        #endregion 

        #region methods

		/// <summary>
		/// Some mombo-jombo logic to get a customer. Example of methods within a class
		/// </summary>
		/// <param name="CustomerHolders"></param>
		/// <returns></returns>
        //public Customer GetCustomer(List<Customer> CustomerHolders)
        //{
        //    Customer CustomerHolder;

        //    CustomerHolder = CustomerHolders.Find(cus => cus.customerId == this.customerId);
            
        //    return CustomerHolder;
        //}


        #endregion

        #region IDomainObject Members

        public  object Id
        {
            get { return addressId; }
        }

        
        #endregion

        #region Validation

        //public IValidationResult Validate()
        //{
        //    IValidator<IAddress> val = ValidationFactory.GetValidator<IAddress>();
        //    return val.Validate(this);
        //}

        #endregion

    }
}
