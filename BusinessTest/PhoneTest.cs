using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Microsoft.Practices.Unity;

using Template.Business;
using Template.DomainInterface;


namespace Template.BusinessTest
{
    /// <summary>
    /// Summary description for BusinessObjectTest
    /// </summary>
    [TestClass]
    public class PhoneTest
    {
        public PhoneTest()
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

        private readonly int phoneTestId = 1;

        [TestMethod]
        public void CreateBusinessObjects()
        {
            Phone ph= new Phone();
            Assert.IsTrue(ph!= null);
        }

        [TestMethod]
        public void TestGetPhoneById()
        {
            int entityId = phoneTestId;

            IUnityContainer container = GenericSingleton<ComponentContainer>.GetInstance().Container;

            IDomainFactory factory = container.Resolve<PhoneFactory>();

            Phone ph= (Phone)factory.GetBusinessEntityById(entityId);

            Assert.AreEqual(entityId, ph.BusinessEntityID);

        }


        [TestMethod]
        public void TestGetPhoneByMasterId()
        {
            int masterId = 504438;

            IUnityContainer container = GenericSingleton<ComponentContainer>.GetInstance().Container;

            IDomainFactory factory = container.Resolve<PhoneFactory>();

            Phone ph= (Phone)factory.GetBusinessEntityByMasterEntityId(masterId);

            Assert.AreEqual(masterId, ph.customerId);

        }

        [TestMethod]
        public void TestUpdatePhone()
        {
            int entityId = phoneTestId;

            IUnityContainer container = GenericSingleton<ComponentContainer>.GetInstance().Container;

            IDomainFactory factory = container.Resolve<PhoneFactory>();

            Phone ph = (Phone)factory.GetBusinessEntityById(entityId);

            ph.phoneNumber = "6125551234";
            
            ph.Update();

            Assert.AreEqual(entityId, ph.BusinessEntityID);
        }

        [TestMethod]
        public void TestAddPhone()
        {
            IUnityContainer container = GenericSingleton<ComponentContainer>.GetInstance().Container;

            IDomainFactory factory = container.Resolve<PhoneFactory>();

            Phone ph= (Phone)factory.CreateBusinessEntity();
            
            ph.phoneNumber = "6125551234";

            ph.AddToDb();

            Phone phNew = (Phone)factory.GetBusinessEntityById(ph.phoneId);

            Assert.AreEqual(phNew.BusinessEntityID, ph.BusinessEntityID);

        }


        [TestMethod]
        public void TestDeletePhone()
        {
            IUnityContainer container = GenericSingleton<ComponentContainer>.GetInstance().Container;

            IDomainFactory factory = container.Resolve<PhoneFactory>();

            Phone ph= (Phone)factory.CreateBusinessEntity();

            ph.phoneNumber = "6125551234";

            ph.AddToDb();

            Phone phNew = (Phone)factory.GetBusinessEntityById(ph.phoneId);

            Assert.AreEqual(phNew.BusinessEntityID, ph.BusinessEntityID);

            phNew.Delete();

            Phone phNull = (Phone)factory.GetBusinessEntityById(phNew.phoneId);

            Assert.IsNull(phNull);
        }




        [TestMethod]
        public void TestUpdateBeforeInDB()
        {
            IUnityContainer container = GenericSingleton<ComponentContainer>.GetInstance().Container;

            IDomainFactory factory = container.Resolve<PhoneFactory>();

            Phone ph= (Phone)factory.CreateBusinessEntity();

            ph.phoneNumber = "6515551234";

            Exception genEx;

            try
            {
                ph.Update();
            }
            catch (InvalidOperationException ex)
            {
                genEx = ex;
            }
        }


        [TestMethod]
        public void TestDeleteBeforeInDB()
        {
            IUnityContainer container = GenericSingleton<ComponentContainer>.GetInstance().Container;

            IDomainFactory factory = container.Resolve<PhoneFactory>();

            Phone ph= (Phone)factory.CreateBusinessEntity();

            ph.phoneNumber = "6515551234";

            try
            {
                ph.Delete();
            }
            catch (InvalidOperationException ex)
            {
                Assert.IsTrue(true, ex.Message);
            }
        }

    }
}
