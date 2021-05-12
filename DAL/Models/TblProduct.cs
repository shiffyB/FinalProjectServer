using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TblProduct
    {
        public TblProduct()
        {
            TblOrders = new HashSet<TblOrder>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string BarCode { get; set; }
        public double Price { get; set; }
        public int CompanyId { get; set; }
        public int StoreId { get; set; }
        public int DivisionTypeId { get; set; }
        public double AmountOfStock { get; set; }
        public string Link { get; set; }

        public virtual TblCompany Company { get; set; }
        public virtual TblDivisionType DivisionType { get; set; }
        public virtual TblStore Store { get; set; }
        public virtual ICollection<TblOrder> TblOrders { get; set; }
    }
}
