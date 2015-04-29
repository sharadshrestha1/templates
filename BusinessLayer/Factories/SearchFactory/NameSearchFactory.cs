using Template.DomainInterface.Search;
using Template.DomainInterface;

namespace Template.Business
{
    public class NameSearchFactory: ISearchFactory
    {
        #region ISearchFactory Members

        public ISearchType CreateSearchType(ISearchCriteria SearchCriteria)
        {
            return new NameSearch(SearchCriteria);
        }

        #endregion
    }
}
