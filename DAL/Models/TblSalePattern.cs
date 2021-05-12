using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TblSalePattern
    {
        public TblSalePattern()
        {
            TblSalePatternsParams = new HashSet<TblSalePatternsParam>();
        }

        public int PatternId { get; set; }
        public string PatternDescription { get; set; }

        public virtual ICollection<TblSalePatternsParam> TblSalePatternsParams { get; set; }
    }
}
