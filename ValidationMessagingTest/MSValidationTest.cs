using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Practices.EnterpriseLibrary.Validation;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;
using Template.BusinessLayer;



namespace ValidationTest
{
    /// <summary>
    /// Summary description for MSValidationTest
    /// </summary>
    [TestClass]
    public class MSValidationTest
    {
        public MSValidationTest()
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
        public void TestMethod1()
        {
			Customer myCustomer = new Customer() { firstName = " A Name tat is too long for the validation" };

            Validator shortStringValidator = new AndCompositeValidator(new NotNullValidator(), new StringLengthValidator(1,50));

			ValidationResults r = shortStringValidator.Validate(myCustomer.firstName);

            //ValidationResults r = Validation.Validate<Customer>(myCustomer);
            if (!r.IsValid)
            {
                throw new InvalidOperationException("Validation error found.");
            }
        }

        [TestMethod]
        public void TestMethod2()
        {
			Customer myCustomer = new Customer() { firstName = " A Name tat is too long for the validation" };

            //Validation using Config File...
            ValidationResults r = Validation.Validate<Customer>(myCustomer);
            
            if (!r.IsValid)
            {
                throw new InvalidOperationException("Validation error found.");
            }
        }

    }
}
