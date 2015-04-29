using System;
using Template.DomainInterface;
using Template.DataAccessLayer;
using biz = Template.BusinessLayer;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestDataAccess
{
    /// <summary>
    /// Summary description for AddressTest
    /// </summary>
    [TestClass]
    public class AddressTest
    {
        private readonly int testAddressId = 701181;

        public AddressTest()
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
        public void GetAddressByIdRepositoryTest()
        {
            int id = testAddressId;

            using (AddressRepository cr = new AddressRepository())
            {
                IAddress address = cr.GetEntityById(id);

                Assert.AreEqual(id, address.addressId);
            }
        }

        [TestMethod]
        public void UpdateAddressTest()
        {
            int id = testAddressId;
            using (AddressRepository cr = new AddressRepository())
            {
                IAddress address = cr.GetEntityById(id);

                address.state = "MN";

                cr.Update(address);

                IAddress address1 = cr.GetEntityById(id);

                Assert.AreEqual(address.addressLine1, address1.addressLine1);
            }
        }

        [TestMethod]
        public void AddAddressTest()
        {
            int id = testAddressId;
            using (AddressRepository res = new AddressRepository())
            {
                IAddress address = res.GetEntityById(id);

                IAddress addressNew = new biz.Address();

                //address.MapPrimitiveNullOnly(addressNew);

                addressNew.customerId = address.customerId;
                //addressNew.AddressCodeID = 1;
                addressNew.addressLine1 = "123 Test st";
                addressNew.city = "Woodbury";
                addressNew.zipCode = "55125";
                
                int addressidnew  = res.Add(addressNew);

                IAddress address1 = res.GetEntityById(addressidnew);

                Assert.AreEqual(address1.addressId, addressidnew);
            }
        }


        [TestMethod]
        public void AddressLoggerTest()
        {
            using (AddressRepository cr = new AddressRepository())
            {
                IAddress address = new biz.Address();

                address.addressLine1 = "Test" + DateTime.Now.Second.ToString();

                try
                {
                    cr.Update(address);
                }
                catch (InvalidOperationException ex)
                {
                    Assert.IsTrue(true, ex.Message);
                }
                catch
                {
                    Assert.Fail();
                }
            }
        }


        [TestMethod]
        public void AddressTypeListTest()
        {
            //EntityGetTypes elp = new EntityGetTypes();
            //var v = elp.GetEntityType(enmEntityTypes.AddressType);
        }
    }
}
