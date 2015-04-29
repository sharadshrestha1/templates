namespace Template.Data.ORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProspectDeniedAppPrinted")]
    public partial class ProspectDeniedAppPrinted
    {
        [Key]
        public Guid ProspectID { get; set; }

        public DateTime DatePrinted { get; set; }
    }
}
