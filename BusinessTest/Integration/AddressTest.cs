using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Microsoft.Practices.Unity;

using Template.Busines;
using Template.DomainInterface;
using Template.Business.Interface.Repository;
using System.Data.Entity;


namespace Template.BusinessTest
{
    using Template.Data.ORM;
    using Template.Data.ORM.Repository;
    using Template.Business.Interface.Domain;
    using Template.Business.Interface.Factory;
    using Template.Business;
    using Template.Business.DTO;
    using Template.Business.Domain;

    /// <summary>
    /// Summary description for BusinessObjectTest
    /// </summary>
    [TestClass]
    public class AddressTest
    {

        /// <summary>The container.</summary>
        private readonly IUnityContainer container;

        /// <summary>The repository.</summary>
        private readonly IRepository<AddressDto> repository;


        public AddressTest()
        {
            //
            // TODO: Add constructor logic here

            this.container = new UnityContainer();
            this.container.RegisterType<DbContext, HFBDataContext>("HFB");
            this.container.RegisterType(typeof(IRepository<>), typeof(GenericRepository<>));
            this.container.RegisterType<IDomainObject, Address>("Address");
            this.container.RegisterType<IDomainFactory, AddressFactory>("AddressFactory");

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

        private readonly int AddressTestId = 701232;

        [TestMethod]
        public void CreateBusinessObjects()
        {
            IDomainFactory factory = this.container.Resolve<IDomainFactory>("AddressFactory");
          
            Address ad = (Address)factory.CreateDomainObject();
            Assert.IsTrue(ad!= null);
        }



        [TestMethod]
        public void TestGetAddressById()
        {
            //IDomainFactory factory = this.container.Resolve<IDomainFactory>("AddressFactory");
            var repo = new GenericRepository<AddressDto>();
            
            IDomainFactory factory = new AddressFactory(repo);

            string test = string.Format("{0} Main St", DateTime.Now.Second);

            Address address = (Address)factory.CreateDomainObject(1);

            address.addressLine1 = test;

            address.Persist();

            Assert.IsNotNull(address.addressLine1, test);

        }


        [TestMethod]
        public void TestGetAddressByMasterId()
        {
            //int masterId = 504438;

            //var AddressList = Repository.GetEntitiesByMasterId(masterId);

            //foreach (var Address in AddressList)
            //{
            //    Assert.AreEqual(masterId, Address.customerId);
            //}
        }

        [TestMethod]
        public void TestUpdateAddress()
        {
            //int entityId = AddressTestId;

            //Address ad = (Address)Repository.GetEntityById(entityId);

            //var changedAddress  = DateTime.Now.Second.ToString() +  " Change St";

            //ad.addressLine1 = changedAddress;
            
            //ad.Update();

            //repository.datacontext.address will have be the original address and not the updated until that is released from memory
            ////Get it again after update
            //ad = (Address)repository.GetEntityById(entityId);
            //Assert.AreEqual(changedAddress, ad.addressLine1);
        }

        //[TestMethod]
        //public void TestAddAddress()
        //{
        //    Address newAddress = new Address();

        //    newAddress.addressLine1 = "123 Newer Rd";
        //    newAddress.city = "Newville";
        //    newAddress.state = "NM";
        //    newAddress.zipCode = "34234";

        //    newAddress.AddToDb();

        //    Address ad = (Address)Repository.GetEntityById(newAddress.addressId);

        //    Assert.AreEqual(newAddress.addressId, ad.BusinessEntityID);
        //}


        //[TestMethod]
        //public void TestDeleteAddress()
        //{
        //    Address newAddress = new Address();

        //    newAddress.addressLine1 = "123 UWontCIt Ct";
        //    newAddress.city = "NoCity";
        //    newAddress.state = "NM";
        //    newAddress.zipCode = "34234";

        //    newAddress.AddToDb();

        //    newAddress.Delete();

        //    Address emNull = (Address)Repository.GetEntityById(newAddress.addressId);

        //    Assert.IsNull(emNull);
        //}

        //[TestMethod]
        //public void SetAsPrimary()
        //{
        //    int entityId = AddressTestId;

        //    Address ad = (Address)Repository.GetEntityById(entityId);

        //    ad.UpdatePrimaryAddress(ad.addressId, ad.customerId.Value);

        //}

    }
}
