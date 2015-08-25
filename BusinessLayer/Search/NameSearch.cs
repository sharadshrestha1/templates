using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Template.DomainInterface.Search;


namespace Template.Business
{
    public class NameSearch //:ISearchType
    {
        public ISearchCriteria SearchCriteria { get; set; }

        public NameSearch(ISearchCriteria SearchCriteria)
        {
            this.SearchCriteria = SearchCriteria;
        }

        //public List<ISearchResult> Search()
        //{
        //    List<ISearchResult> list;

        //    var Container = GenericSingleton<ComponentContainer>.GetInstance().Container;
            
        //    ISearchProvider search = (ISearchProvider)Container.Resolve<ISearchProvider>();

        //    search.GetCustomerListBySearchCriteria(SearchCriteria, out list);

        //    return list;
        //}

        
    }
}
