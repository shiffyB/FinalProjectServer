using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TblSale
    {
        public int SaleId { get; set; }
        public int StoreId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int PatternParamId { get; set; }

        public virtual TblSalePatternsParam PatternParam { get; set; }
        public virtual TblStore Store { get; set; }
    }
}
