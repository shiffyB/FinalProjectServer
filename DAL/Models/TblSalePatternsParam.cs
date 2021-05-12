using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TblSalePatternsParam
    {
        public TblSalePatternsParam()
        {
            TblSales = new HashSet<TblSale>();
        }

        public int PatternParamId { get; set; }
        public int PatternId { get; set; }
        public int? ProductsAmount { get; set; }
        public int? ProductsEndAmount { get; set; }
        public double? PriceAmount { get; set; }
        public double DiscountPercent { get; set; }

        public virtual TblSalePattern Pattern { get; set; }
        public virtual ICollection<TblSale> TblSales { get; set; }
    }
}
