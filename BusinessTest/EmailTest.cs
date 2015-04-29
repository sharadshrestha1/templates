using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
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
    public class EmailTest
    {
        public EmailTest()
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

        private readonly int EmailTestId = 1;

        [TestMethod]
        public void CreateBusinessObjects()
        {
            Email em= new Email();
            Assert.IsTrue(em!= null);
        }



        [TestMethod]
        public void TestGetEmailById()
        {
            int entityId = EmailTestId;

            Email em = (Email)Repository.GetEntityById(entityId);

            Assert.AreEqual(entityId, em.BusinessEntityID);

        }


        [TestMethod]
        public void TestGetEmailByMasterId()
        {
            int masterId = 504438;

            var emailList = Repository.GetEntitiesByMasterId(masterId);

            foreach (var email in emailList)
            {
                Assert.AreEqual(masterId, email.customerId);
            }
        }

        [TestMethod]
        public void TestUpdateEmail()
        {
            int entityId = EmailTestId;

            Email em = (Email)Repository.GetEntityById(entityId);

            var changedEmail  = "changeTest@tester.com";

            em.emailAddress = changedEmail;
            
            em.Update();

            //Get it again after update
            em = (Email)repository.GetEntityById(entityId);

            Assert.AreEqual(changedEmail, em.emailAddress);
        }

        [TestMethod]
        public void TestAddEmail()
        {
            Email newEmail = new Email();

            newEmail.emailAddress = "newTest@tester.com";

            newEmail.AddToDb();

            Email em = (Email)Repository.GetEntityById(newEmail.emailId);

            Assert.AreEqual(newEmail.emailId, em.BusinessEntityID);
        }


        [TestMethod]
        public void TestDeleteEmail()
        {
            Email newEmail = new Email();

            newEmail.emailAddress = "newTest@tester.com";

            newEmail.AddToDb();

            newEmail.Delete();

            Email emNull = (Email)Repository.GetEntityById(newEmail.emailId);

            Assert.IsNull(emNull);
        }

    }
}
