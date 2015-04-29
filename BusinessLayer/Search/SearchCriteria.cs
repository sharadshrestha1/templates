using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Template.DomainInterface.Enums;
using Template.DomainInterface.Search;

namespace Template.Business
{
    [Serializable]
    public class SearchCriteria : ISearchCriteria
    {
		public int IDNumber { get; set; }
		public string Name { get; set; }
		public DateTime DateOfBirth { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public ushort ZipCode { get; set; }

		public enmSearchTypes SearchType { get; set; }

        public void Reset()
        {
            IDNumber = 0;
			Name = string.Empty;
            DateOfBirth = DateTime.MinValue;
            FirstName = string.Empty;
            LastName = string.Empty;
            City = string.Empty;
            State = string.Empty;
            ZipCode = 0;
        }

    }
}
