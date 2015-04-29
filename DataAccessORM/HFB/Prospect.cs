namespace Template.Data.ORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Prospect
    {
        public Guid ProspectId { get; set; }

        public Guid? ZipCodeId { get; set; }

        [StringLength(11)]
        public string SSN { get; set; }

        [StringLength(255)]
        public string EmailAddress { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string MiddleName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Birthday { get; set; }

        [StringLength(50)]
        public string Address1 { get; set; }

        [StringLength(50)]
        public string Address2 { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(50)]
        public string State { get; set; }

        [StringLength(50)]
        public string Zip { get; set; }

        [StringLength(50)]
        public string PhoneNumber { get; set; }

        public int? Approved { get; set; }

        public int? Status { get; set; }

        [StringLength(2000)]
        public string Reason { get; set; }

        [StringLength(255)]
        public string Plan { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Created { get; set; }

        public int? AccountNumber { get; set; }

        [StringLength(50)]
        public string ReportTextMessage { get; set; }
    }
}
