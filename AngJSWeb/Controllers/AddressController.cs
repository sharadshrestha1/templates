using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

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

        // GET api/employees
        public IEnumerable<Employee> Get()
        {
            return list;
        }


    }

    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
