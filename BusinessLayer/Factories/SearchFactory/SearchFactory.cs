using Template.DomainInterface;
using Template.DomainInterface.Enums;



namespace Template.Business
{
    public class SearchFactory
    {
        #region ISearchFactory Members

        public static ISearchFactory GetFactory(enmSearchTypes SearchType)
        {
            switch (SearchType)
            {
                case enmSearchTypes.CustomSearch:
                case enmSearchTypes.NumberSearch:
                    return new ConsumerSearchFactory();    
                case enmSearchTypes.NameSearch:
                    return new NameSearchFactory();
            }

            return null;
        }

        #endregion
       
    }
}
