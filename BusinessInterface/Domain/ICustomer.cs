using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Template.Business.Interface.Domain
{
	/// <summary>
	/// General customer entity
	/// </summary>
    public interface ICustomer 
    { 
		/* SE NOTE: By not doing ICustomer: IDomainObject, we are freeing up the overhead for having to tie
		 * any class that implements ICustomer to IBusinessEnitity also
		 */

		/// <summary>
		/// Customer ID
		/// </summary>
		int customerId { get; set; }
		
		/// <summary>
		/// Number for Customer
		/// </summary>
		string customerNumber { get; set; }
        
		//SE: This may need to split out because only Idividual would have cusotmer but 
		//this is just an example
		DateTime? birthDate { get; set; }
		
        string firstName { get; set; }
        string lastName { get; set; }
        char? middleInitial { get; set; }
        string occupation { get; set; }
        string SSN { get; set; }
        string suffix { get; set; }
        string title { get; set; }

		//Som List that customer would carry
		IList<IPhone> PhoneList { get; set; }
        IList<IAddress> AddressList { get; set; }
        IList<IEmail> EmailList { get; set; }

		/* SE NOTE: By moving properties like createDate, createUserID to IDomainObject, we are 
		 * making all the CRUD related fields come from a single interface
		*/

    }
}
