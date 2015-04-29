using Template.DomainInterface;
using Template.DomainInterface.Enums;
using Template.DomainInterface.Search;

namespace Template.Business
{
	/* Factory Pattern. ISearchFactory returns ISearchType 
	*/
    public class ConsumerSearchFactory: ISearchFactory
    {
		/// <summary>
		/// 
		/// </summary>
		/// <param name="SearchCriteria"></param>
		/// <returns></returns>
        #region ISearchFactory Members

        public ISearchType CreateSearchType(ISearchCriteria SearchCriteria)
        {
			/*
			 * SE NOTE: This is the main if check to decide what kind of Search to generate. 
			 * In this case, you could return two different flavors of Search for ConsumerSearchFactory
			 * 
			 */
            if (SearchCriteria.SearchType == enmSearchTypes.NumberSearch)
            {
                return new NumberSearch(SearchCriteria);
            }
            else
            {
                return new NameSearch(SearchCriteria);
            }
        }

        #endregion
    }
}
