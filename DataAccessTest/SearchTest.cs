//using System;
//using System.Text;
//using System.Collections.Generic;
//using System.Linq;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Template.DataAccessLayer;
//using Template.BusinessInterface;
//using Template.BusinessInterface.Enums;
//using Template.BusinessInterface.Search;

//namespace TestDataAccess
//{
//    /// <summary>
//    /// Summary description for Search
//    /// </summary>
//    [TestClass]
//    public class SearchTest
//    {
//        public SearchTest()
//        {
//            //
//            // TODO: Add constructor logic here
//            //
//        }

//        private TestContext testContextInstance;

//        /// <summary>
//        ///Gets or sets the test context which provides
//        ///information about and functionality for the current test run.
//        ///</summary>
//        public TestContext TestContext
//        {
//            get
//            {
//                return testContextInstance;
//            }
//            set
//            {
//                testContextInstance = value;
//            }
//        }

//        #region Additional test attributes
//        //
//        // You can use the following additional attributes as you write your tests:
//        //
//        // Use ClassInitialize to run code before running the first test in the class
//        // [ClassInitialize()]
//        // public static void MyClassInitialize(TestContext testContext) { }
//        //
//        // Use ClassCleanup to run code after all tests in a class have run
//        // [ClassCleanup()]
//        // public static void MyClassCleanup() { }
//        //
//        // Use TestInitialize to run code before running each test 
//        // [TestInitialize()]
//        // public void MyTestInitialize() { }
//        //
//        // Use TestCleanup to run code after each test has run
//        // [TestCleanup()]
//        // public void MyTestCleanup() { }
//        //
//        #endregion

//        [TestMethod]
//        public void TestMethod1()
//        {
//            //
//            // TODO: Add test logic	here
//            //
//        }

//        [TestMethod]
//        public void TestSearchByNumber()
//        {
//            int number = 123456;
//            Search s = new Search();
//            List<ISearchResult> list;
//            s.GetCustomerListByNumber(number, out list);
//        }

//        [TestMethod]
//        public void TestSearchByCustomer()
//        {
//            //Create search criteria
//            SearchCriteria sc = new SearchCriteria();
//            sc.FirstName = "test";
//            sc.SearchType = enmSearchTypes.NameSearch;

//            //create search
//            Search s = new Search();
//            List<ISearchResult> list;
//            s.GetCustomerListBySearchCriteria(sc, out list);

//        }


//        //You can create your own Search Criteria as long as you implement ISearchCriteria
//        private class SearchCriteria : ISearchCriteria
//        {
//            #region general seacrh criteria

//            public int IDNumber { get; set; }
//            public string Name { get; set; }
//            public DateTime DateOfBirth { get; set; }
//            public string FirstName { get; set; }
//            public string LastName { get; set; }
//            public string City { get; set; }
//            public string State { get; set; }
//            public ushort ZipCode { get; set; }

//            public  enmSearchTypes SearchType { get; set; }

//            #endregion
//        }

//    }
//}
