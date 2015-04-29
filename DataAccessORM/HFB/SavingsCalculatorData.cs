namespace Template.Data.ORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SavingsCalculatorData")]
    public partial class SavingsCalculatorData
    {
        public int SavingsCalculatorDataId { get; set; }

        [Column(TypeName = "money")]
        public decimal FirstFillPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal AdvantageProgramPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal SalesTax { get; set; }

        [Column(TypeName = "money")]
        public decimal CurrentPriceEntered { get; set; }

        public int AnnualUsageEntered { get; set; }

        [Column(TypeName = "money")]
        public decimal FirstYearCalculated { get; set; }

        [Column(TypeName = "money")]
        public decimal SecondYearCalculated { get; set; }

        public DateTime DateTime { get; set; }
    }
}
