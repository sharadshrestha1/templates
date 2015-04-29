namespace Template.Data.ORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ZipCode
    {
        public Guid ZipCodeId { get; set; }

        [Column("ZipCode")]
        [StringLength(25)]
        public string ZipCode1 { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? EntryDate { get; set; }

        public int? Valid { get; set; }

        public int? CompanyId { get; set; }

        public int? DivisionId { get; set; }

        [StringLength(255)]
        public string NotifyAddress { get; set; }
    }
}
