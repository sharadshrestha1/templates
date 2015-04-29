namespace Template.Data.ORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserMessage")]
    public partial class UserMessage
    {
        [Key]
        [Column(Order = 0)]
        public int UserMessageId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(250)]
        public string Email { get; set; }

        public int? MessageId { get; set; }
    }
}
