using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TblOrderApply
    {
        public TblOrderApply()
        {
            TblItemsOfOrders = new HashSet<TblItemsOfOrder>();
        }

        public int OrderApplyId { get; set; }
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public int Quantity { get; set; }
        public int UpdateId { get; set; }
        public DateTime ApplyDate { get; set; }

        public virtual TblOrder Order { get; set; }
        public virtual TblUpdate Update { get; set; }
        public virtual TblUser User { get; set; }
        public virtual ICollection<TblItemsOfOrder> TblItemsOfOrders { get; set; }
    }
}
