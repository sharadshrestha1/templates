using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Template.DomainInterface;
using Template.DomainInterface.Enums;
using Template.Business;
using Template.DomainInterface.Search;

namespace Template.BusinessTest
{
    /// <summary>
    /// Summary description for SearchTest
    /// </summary>
    [TestClass]
    public class SearchTest
    {
        public SearchTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestNumberSearch()
        {
            SearchCriteria sc = new SearchCriteria();
			sc.SearchType = enmSearchTypes.NumberSearch;
            sc.IDNumber = 123456;

            ISearchFactory numberFactory =  SearchFactory.GetFactory(sc.SearchType);
			ISearchType searchType = numberFactory.CreateSearchType(sc);
			List<ISearchResult> result = searchType.Search();

        }


        [TestMethod]
        public void TestNameSearch()
        {
            SearchCriteria sc = new SearchCriteria();
            sc.SearchType = enmSearchTypes.NameSearch;
            sc.Name = "TextName";

            ISearchFactory nameFactory = SearchFactory.GetFactory(sc.SearchType);
            ISearchType searchType = nameFactory.CreateSearchType(sc);
            List<ISearchResult> result = searchType.Search();

        }


    }
}
