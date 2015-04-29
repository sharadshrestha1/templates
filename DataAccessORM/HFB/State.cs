namespace Template.Data.ORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class State 
    {
        [StringLength(2)]
        public string ID { get; set; }

        [StringLength(50)]
        public string DESCR { get; set; }
    }
}
