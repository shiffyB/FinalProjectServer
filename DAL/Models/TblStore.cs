using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TblStore
    {
        public TblStore()
        {
            TblProducts = new HashSet<TblProduct>();
            TblSales = new HashSet<TblSale>();
        }

        public int StoreId { get; set; }
        public string StoreName { get; set; }
        public string Lat { get; set; }
        public string Lng { get; set; }
        public string StoreAddress { get; set; }

        public virtual ICollection<TblProduct> TblProducts { get; set; }
        public virtual ICollection<TblSale> TblSales { get; set; }
    }
}
