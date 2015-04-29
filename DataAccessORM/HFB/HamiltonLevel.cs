namespace Template.Data.ORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HamiltonLevel
    {
        public int ID { get; set; }

        public DateTime ImportDateTime { get; set; }

        [StringLength(50)]
        public string ts_location { get; set; }

        [StringLength(50)]
        public string tk_level { get; set; }

        [StringLength(50)]
        public string rpt_date_ti { get; set; }

        [StringLength(50)]
        public string tx_num_ti { get; set; }

        [StringLength(12)]
        public string ts_tankserialnum { get; set; }

        [StringLength(50)]
        public string base_id_ti { get; set; }

        [StringLength(50)]
        public string address_bi { get; set; }

        [StringLength(50)]
        public string city_bi { get; set; }

        [StringLength(2)]
        public string state_bi { get; set; }

        [StringLength(50)]
        public string ts_access { get; set; }

        [StringLength(50)]
        public string tk_w_dau { get; set; }

        [StringLength(50)]
        public string ts_capacity { get; set; }

        [StringLength(50)]
        public string tat_ttanklow { get; set; }

        [StringLength(50)]
        public string tat_ttankcrit { get; set; }

        [StringLength(50)]
        public string ts_cat_1 { get; set; }

        [StringLength(50)]
        public string ts_cat_2 { get; set; }

        [StringLength(50)]
        public string ts_cat_3 { get; set; }

        [StringLength(50)]
        public string ts_cat_4 { get; set; }

        [StringLength(50)]
        public string ts_code { get; set; }

        [StringLength(50)]
        public string base_temp { get; set; }
    }
}
