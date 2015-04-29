namespace Template.Data.ORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EFTHold")]
    public partial class EFTHold
    {
        [Key]
        public int Remittance_Id { get; set; }

        [Required]
        [StringLength(320)]
        public string EmailAddress { get; set; }

        public DateTime DateTime { get; set; }

        [Column(TypeName = "text")]
        public string Text { get; set; }

        [StringLength(50)]
        public string ReferenceNumber { get; set; }

        public decimal? PaymentAmount { get; set; }

        [StringLength(50)]
        public string Security_Id { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        public int? AccountNumber { get; set; }
    }
}
