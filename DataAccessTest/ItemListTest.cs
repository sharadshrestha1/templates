//using System;
//using System.Text;
//using System.Collections.Generic;
//using System.Linq;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Template.DataAccessLayer;
//using Template.BusinessInterface.Enums;
//using Template.BusinessInterface;
//using Template.BusinessLayer;
//using biz = Template.BusinessLayer;

//namespace TestDataAccess
//{
//    /// <summary>
//    /// Summary description for CommonTest
//    /// </summary>
//    [TestClass]
//    public class ItemListTest
//    {
//        public ItemListTest()
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
//        public void StateListTest()
//        {
//            ItemGetList igl = new ItemGetList();
//            //SE NOTE: Create a ItemGetList and just pass in the param [State in this case] to get what you need
//            var list = igl.GetList<biz.State>(); 
//            //GetList method will take care of returning what you asked for
//        }


//    }
//}
