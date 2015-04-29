using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Template.DomainInterface.Enums;

namespace Template.DomainInterface.Search
{
	/// <summary>
	/// Interface defining search criteria
	/// </summary>
    public interface ISearchCriteria
	{
		#region general seacrh criteria

		int IDNumber { get; set; }
        string Name { get; set; }
		DateTime DateOfBirth { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string City { get; set; }
        string State { get; set; }
        ushort ZipCode { get; set; }

		#endregion

		/// <summary>
		/// Enum Search Types that defines what kind of search is being performed
		/// </summary>
		enmSearchTypes SearchType { get; set; }
    }
}
