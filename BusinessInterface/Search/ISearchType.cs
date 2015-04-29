using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Template.DomainInterface.Search
{
    public interface ISearchType
    {
        ISearchCriteria SearchCriteria { get; set; }
        List<ISearchResult> Search();
    }
}
