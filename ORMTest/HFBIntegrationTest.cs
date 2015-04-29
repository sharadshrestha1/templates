using System;
using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Template.DataAccessLayer.UoW;

namespace ORMTest
{
    [TestClass]
    public class HFBIntegrationTest
    {
        [TestMethod]
        public void GetlistOfProspects()
        {
            using (var uow = new UnitOfWork())
            {
                var locationId = Convert.ToInt32(ConfigurationManager.AppSettings["ExistingLocationId"]);
                var test = uow.LocationRepository.GetByID(locationId);
                
                Assert.IsNotNull(test);
            }

        }
    }
}
