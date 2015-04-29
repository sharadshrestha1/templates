using System;
using Microsoft.Practices.Unity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Template.Business;
using Template.Business.Interface.Domain;
using Template.Business.Interface.Factory;
using Template.Business.Interface.Repository;
using Template.Data.ORM.Repository;

namespace BusinessTest.Integration
{
    using Template.Business.DTO;

    [TestClass]
    public class StateTest
    {
        private IUnityContainer container;

        /// <summary>The repository.</summary>
        private readonly IRepository<StateDto> repository;

        [TestMethod]
        public void TestMethod1()
        {
            //this.container = new UnityContainer();
            ////this.container.RegisterType<DbContext, HFBDataContext>("HFB");
            //this.container.RegisterType(typeof(IRepository<>), typeof(GenericRepository<>));
            //this.container.RegisterType<IDomainObject, State>("State");
            //this.container.RegisterType<IDomainFactory, StateFactory>("StateFactory");

            //var repo = new GenericRepository<StateDto>();

            //var StateFactory = new StateFactory(repo);

            //var state = StateFactory.CreateDomainObject("MN");

            //Assert.IsNotNull(state);

        }
    }
}
