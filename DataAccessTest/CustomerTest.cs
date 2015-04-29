using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Template.DataAccessLayer;
using Template.DomainInterface;
using Template.BusinessLayer;

namespace TestDataAccess
{
    /// <summary>
    /// Summary description for CustomerTest
    /// </summary>
    [TestClass]
    public class CustomerTest
    {
        private readonly int testCustomerId = 495773;
        
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

        [TestMethod]
        public void GetCustomerByIdRepositoryTest()
        {
            int id = testCustomerId;

            //using (CustomerRepository cr = new CustomerRepository())
            //{
            //    ICustomer customer = cr.GetEntityById(id);

            //    Assert.AreEqual(id, customer.customerId);
            //}
        }

        

        [TestMethod, Ignore]
        public void UpdateCustomerTest()
        {
            int id = testCustomerId;
            //using (CustomerRepository cr = new CustomerRepository())
            //{
            //    ICustomer customer = cr.GetEntityById(id);

            //    customer.lastName = "Test" + DateTime.Now.Second.ToString();

            //    cr.Update(customer);

            //    ICustomer customer1 = cr.GetEntityById(id);

            //    Assert.AreEqual(customer.lastName, customer1.lastName);
            //}
        }

        [TestMethod,Ignore]
        public void AddCustomerTest()
        {
            int id = testCustomerId;
            //using (CustomerRepository cr = new CustomerRepository())
            //{
            //    ICustomer customer = cr.GetEntityById(id);

            //    customer.lastName = "Test" + DateTime.Now.Second.ToString();

            //    int customerid = cr.Add(customer);

            //    ICustomer customer1 = cr.GetEntityById(customerid);

            //    Assert.AreEqual(customer1.customerId, customerid);
            //}
        }

        [TestMethod, Ignore]
        public void RemoveCustomerTest()
        {
            int id = testCustomerId;
            //using (CustomerRepository cr = new CustomerRepository())
            //{
            //    ICustomer customer = cr.GetEntityById(id);

            //    customer.lastName = "Test" + DateTime.Now.Second.ToString();

            //    int customerid = cr.Add(customer);

            //    ICustomer customer1 = cr.GetEntityById(customerid);

            //    Assert.AreEqual(customer1.customerId, customerid);

            //    cr.Remove(customerid);

            //    ICustomer customerNew = cr.GetEntityById(customerid);

            //    Assert.IsNull(customerNew);
            //}
        }

        [TestMethod, Ignore]
        public void CustomerLoggerTest()
        {
            //using (CustomerRepository cr = new CustomerRepository())
            //{
            //    ICustomer customer = new Customer();

            //    customer.lastName = "Test" + DateTime.Now.Second.ToString();

            //    try
            //    {
            //        cr.Update(customer);
            //    }
            //    catch (InvalidOperationException ex)
            //    {
            //        Assert.IsTrue(true, ex.Message);
            //    }
            //    catch
            //    {
            //        Assert.Fail();
            //    }
            //}
        }

    }
}
