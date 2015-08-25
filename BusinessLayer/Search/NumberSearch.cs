using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Template.DomainInterface.Search;


namespace Template.Business
{
    public class NumberSearch //:ISearchType
    {
        public ISearchCriteria SearchCriteria { get; set; }

        public NumberSearch(ISearchCriteria SearchCriteria)
        {
            this.SearchCriteria = SearchCriteria;
        }

        //public List<ISearchResult> Search()
        //{
        //    List<ISearchResult> list;

        //    var Container = GenericSingleton<ComponentContainer>.GetInstance().Container;

        //    ISearchProvider search = (ISearchProvider)Container.Resolve<ISearchProvider>();

        //    search.GetCustomerListByNumber(SearchCriteria.IDNumber, out list);

        //    return list;
        //}
    }
}
