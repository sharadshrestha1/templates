using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Template.Business.Interface.Domain
{
	public interface IEmail 
    {
        int emailId { get; set; }
        string emailAddress { get; set; }
        
		//Customer whom the email would belong to
		int? customerId { get; set; }
    }
}
