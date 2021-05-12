using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TblCompany
    {
        public TblCompany()
        {
            TblProducts = new HashSet<TblProduct>();
        }

        public int CompanyId { get; set; }
        public string CompanyName { get; set; }

        public virtual ICollection<TblProduct> TblProducts { get; set; }
    }
}
