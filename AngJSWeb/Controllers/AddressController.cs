using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.Practices.Unity;
using Template.Business;
using Template.Business.Domain;
using Template.Business.DTO;
using Template.Business.Interface.Domain;
using Template.Business.Interface.Factory;
using Template.Business.Interface.Repository;
using Template.Data.ORM;
using Template.Data.ORM.Repository;
using System.Data.Entity;

namespace App.AngJSWeb.Controllers
{
    public class AddressController : ApiController
    {
        void Test(int i)
        {
            var a = i;
        }

        private static IList<Employee> list = new List<Employee>()
    {
        new Employee()
        {
            Id = 12345, FirstName = "John", LastName = "Human"
        },
        new Employee()
        {
            Id = 12346, FirstName = "Jane", LastName = "Public"
        },
        new Employee()
        {
            Id = 12347, FirstName = "Joseph", LastName = "Law"
        }
     };

        /// <summary>The container.</summary>
        private  IUnityContainer container;

        /// <summary>The repository.</summary>
        private readonly IRepository<AddressDto> repository;

        // GET api/employees
        public Address Get()
        {
            this.container = new UnityContainer();
            this.container.RegisterType<DbContext, HFBDataContext>("HFB");
            this.container.RegisterType(typeof(IRepository<>), typeof(GenericRepository<>));
            this.container.RegisterType<IDomainObject, Address>("Address");
            this.container.RegisterType<IDomainFactory, AddressFactory>("AddressFactory");

            var repo = new GenericRepository<AddressDto>();

            IDomainFactory factory = new AddressFactory(repo);

            string test = string.Format("{0} Main St", DateTime.Now.Second);

            Address address = (Address)factory.CreateDomainObject(1);

            address.addressLine1 = test;

            return address;
            //return list;
        }


    }

    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
