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
    /// Summary description for CommonTest
    /// </summary>
	[TestClass]
	public class ItemListTest
	{
		public ItemListTest()
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
		public void GetStateList()
		{
			var list = State.ListAll();

			foreach (var item in list)
			{
				var s = item;
			}

			Assert.IsTrue(list.Count > 0);
		}

		[TestMethod]
		public void GetStateById()
		{
			var state= State.GetStateById(1);

			Assert.IsTrue(state != null);
		}


	}


}
