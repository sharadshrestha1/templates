using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Template.Business.Interface.Domain
{
	public interface IPhone 
    {
        int phoneId { get; set; }

        int? customerId { get; set; }
        string notes { get; set; }
        
        string phoneNumber { get; set; }
        int? phoneTypeId { get; set; }

		//Some relational IDs
		int? CustomerEntityTypeID { get; set; }
        int? PhoneHolderID { get; set; }

    }
}
