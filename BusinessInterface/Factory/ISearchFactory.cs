using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Template.DomainInterface.Search;

namespace Template.DomainInterface
{
	/// <summary>
	/// Search Factory Interface
	/// </summary>
    public interface ISearchFactory
    {
        ISearchType CreateSearchType(ISearchCriteria SearchCriteria);
    }
}
