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
    /// Summary description for PhoneTest
    /// </summary>
    [TestClass]
    public class PhoneTest
    {
        private readonly int testPhoneId = 1;
        
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

        [TestMethod]
        public void GetPhoneByIdRepositoryTest()
        {
            int id = testPhoneId;

            using (PhoneRepository cr = new PhoneRepository())
            {
                IPhone phone = cr.GetEntityById(id);

                Assert.AreEqual(id, phone.phoneId);
            }
        }

        

        [TestMethod]
        public void UpdatePhoneTest()
        {
            int id = testPhoneId;
            using (PhoneRepository cr = new PhoneRepository())
            {
                IPhone phone = cr.GetEntityById(id);

                phone.phoneNumber = "6515555555";

                cr.Update(phone);

                IPhone phone1 = cr.GetEntityById(id);

                Assert.AreEqual(phone.phoneNumber, phone1.phoneNumber);
            }
        }

        [TestMethod]
        public void AddPhoneTest()
        {
            int id = testPhoneId;
            using (PhoneRepository cr = new PhoneRepository())
            {
                IPhone phone = cr.GetEntityById(id);

                phone.phoneNumber = "6515555555";
               
                int phoneid = cr.Add(phone);

                IPhone phone1 = cr.GetEntityById(phoneid);

                Assert.AreEqual(phone1.phoneId, phoneid);
            }
        }

        [TestMethod]
        public void RemovePhoneTest()
        {
            int id = testPhoneId;
            using (PhoneRepository cr = new PhoneRepository())
            {
                IPhone phone = cr.GetEntityById(id);

                phone.phoneNumber = "6515555555";
                
                int phoneid = cr.Add(phone);

                IPhone phone1 = cr.GetEntityById(phoneid);

                Assert.AreEqual(phone1.phoneId, phoneid);

                cr.Remove(phoneid);

                IPhone phoneNew = cr.GetEntityById(phoneid);

                Assert.IsNull(phoneNew);
            }
        }

        [TestMethod]
        public void PhoneLoggerTest()
        {
            using (PhoneRepository cr = new PhoneRepository())
            {
                IPhone phone = new Phone();

                phone.phoneNumber = "6515555555";
                

                try
                {
                    cr.Update(phone);
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

    }
}
