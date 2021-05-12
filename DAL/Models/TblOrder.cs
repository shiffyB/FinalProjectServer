using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TblOrder
    {
        public TblOrder()
        {
            TblOrderApplies = new HashSet<TblOrderApply>();
        }

        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int StatusId { get; set; }
        public int BuyerId { get; set; }
        public DateTime OpenDate { get; set; }
        public DateTime CloseDate { get; set; }

        public virtual TblUser Buyer { get; set; }
        public virtual TblProduct Product { get; set; }
        public virtual TblStatus Status { get; set; }
        public virtual ICollection<TblOrderApply> TblOrderApplies { get; set; }
    }
}
