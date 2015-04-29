using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using System.Configuration;
using Template.ValidationMessaging;
using Template.DomainInterface;
using Template.BusinessLayer;

namespace ValidationTest
{
    /// <summary>
    /// Summary description for CustomerValidationTest
    /// </summary>
    [TestClass]
    public class EntityValidationTest
    {
        public EntityValidationTest()
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

        int Customerid = 453021;


        ICustomer Customer
        {
            get
            {
                IUnityContainer container = GenericSingleton<ComponentContainer>.GetInstance().Container;

                IDomainFactory factory = container.Resolve<CustomerFactory>();

                IDomainObject Customer = factory.GetBusinessEntityById(Customerid);

                return Customer as ICustomer;
            }
        }


        [TestMethod]
        public void TestCustomerValidationMain()
        {
            //This method can be replace with a factory method
            IValidator<ICustomer> val = ValidationFactory.GetValidator<ICustomer>();

            var results = val.Validate(Customer);

            if (results.ValidationMessageList.Count > 0)
            {
                Assert.IsNotNull(results);
                Assert.IsFalse(results.IsValid);
            }
            else
            {
                Assert.IsTrue(results.IsValid);
            }
        }

        [TestMethod]
        public void TestEmailValidation()
        {
            IValidator<IEmail> val = ValidationFactory.GetValidator<IEmail>();

            var resuslt = val.Validate(Customer.EmailList.First());

            if (resuslt.IsValid)
            {
                Assert.IsTrue(resuslt.IsValid);
            }
        }

        [TestMethod]
        public void TestAddressValidation()
        {
            IValidator<IAddress> val = ValidationFactory.GetValidator<IAddress>();

            var resuslt = val.Validate(Customer.AddressList.First());

            if (resuslt.IsValid)
            {
                Assert.IsTrue(resuslt.IsValid);
            }
        }

        [TestMethod]
        public void TestEmailAndAddressValidation()
        {
            //Assigning invalid email
            IEmail emailTest = Customer.EmailList.First();

            emailTest.emailAddress = "NotValidEmail#email,com";

            IValidator<IEmail> valE = ValidationFactory.GetValidator<IEmail>();

            var resuslt = valE.Validate(emailTest);

            if (resuslt.IsValid)
            {
                Assert.IsTrue(resuslt.IsValid);
            }
            
            IValidator<IAddress> valA = ValidationFactory.GetValidator<IAddress>();

            //Assigning invalid zip
            IAddress addressTest = Customer.AddressList.First();

            addressTest.addressTypeId = null;
            addressTest.zipCode = "555aa";

            resuslt = valA.Validate(addressTest);

            if (resuslt.IsValid)
            {
                Assert.IsTrue(resuslt.IsValid);
            }
        }

        


    }
}
