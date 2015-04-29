using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Template.DomainInterface.Enums;

namespace Template.DomainInterface.Search
{
	/// <summary>
	/// Search Result
	/// </summary>
    public interface ISearchResult
    {
        string CustomerNumber { get; set; }
        
		/// <summary>
		/// This would give some leverage on combining First and Last Name or Company's name
		/// </summary>
		string DisplayName { get; }
		
		string CompanyName { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string Address { get; set; }
        string City { get; set; }
        string State { get; set; }
        uint ZipCode { get; set; }
        
		/// <summary>
		/// Enum Search Type 
		/// </summary>
		enmSearchTypes SearchType { get; set; }
    }
}
