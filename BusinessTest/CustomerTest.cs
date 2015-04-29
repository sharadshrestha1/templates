using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Practices.Unity;
using Template.Business;
using Template.DomainInterface;

namespace Template.BusinessTest
{
    /// <summary>
    /// Summary description for CustomerTest
    /// </summary>
    [TestClass]
    public class CustomerTest
    {
        public CustomerTest()
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

        private readonly int custTestId = 495773;

        [TestMethod]
        public void TestGetCustomerById()
        {
            int entityId = custTestId;

            IUnityContainer container = GenericSingleton<ComponentContainer>.GetInstance().Container;

            IDomainFactory factory = container.Resolve<CustomerFactory>();

            IDomainObject c = factory.GetBusinessEntityById(entityId);

            Assert.AreEqual(entityId, c.BusinessEntityID);

        }


       
    }
}
