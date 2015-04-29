using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Template.DomainInterface.Search;
using Template.DomainInterface.Enums;

namespace Template.Business
{
	/// <summary>
	/// SearchResult class that can be directly bound to a grid. 
	/// </summary>

    [Serializable]
    public class SearchResult:ISearchResult
    {
        public int CustomerId { get; set; }
        public string CustomerNumber { get; set; }
        public int CustomerTypeId { get; set; }
        public int? CustomerStatusId { get; set; }
        public string CompanyName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public uint ZipCode { get; set; }
        public enmSearchTypes SearchType { get; set; }

        public string DisplayName
        {
            get 
            {
                if (CustomerTypeId == 1)
                {
                    return string.Format("{0} {1}", FirstName, LastName);
                }
                return CompanyName;
            }
        }
    }
}
