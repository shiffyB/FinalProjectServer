using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TblDivisionType
    {
        public TblDivisionType()
        {
            TblProducts = new HashSet<TblProduct>();
        }

        public int DivisionId { get; set; }
        public string DivisionName { get; set; }

        public virtual ICollection<TblProduct> TblProducts { get; set; }
    }
}
