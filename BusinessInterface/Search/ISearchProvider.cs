using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Template.DomainInterface.Search
{
	/// <summary>
	/// Search Provider Interfaces. Implement this interface for different types of searches
	/// </summary>
    public interface ISearchProvider
    {
        void SearchCustomerListBySomeText(string someNumber, out List<ISearchResult> ResultList);
		void GetCustomerListBySearchCriteria(ISearchCriteria SearchCriteria, out List<ISearchResult> ResultList);
		void GetCustomerListByNumber(int number, out List<ISearchResult> ResultList);
    }
}
