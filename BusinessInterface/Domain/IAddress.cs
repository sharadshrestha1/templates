using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Template.Business.Interface.Domain
{
    using Template.DomainInterface.DTO;

    /// <summary>
	/// Address DataStructure that represents Real World Address Properties
	/// </summary>
	public interface IAddress 
    {
        IAddressDto AddressDto { get; set; }

        /// <summary>
		/// ID of the address entity
		/// </summary>
        int addressId { get; set; }

		
		/// <summary>
		/// Type of Address in integer. eg Home = 1, Business = 2
		/// </summary>
		int? addressTypeId { get; set; }
       
        
		/// <summary>
		/// Relational Field. CustomerID to whom the Address would belong to
		/// </summary>
		int? customerId { get; set; }
		
		/// <summary>
		/// Relational Field. Some other id field
		/// </summary>
		int? AddressModeID { get; set; }

		
    }
}
