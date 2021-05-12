using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TblItemsOfOrder
    {
        public int ItemOfOrderId { get; set; }
        public int OrderApplyId { get; set; }
        public double Price { get; set; }

        public virtual TblOrderApply OrderApply { get; set; }
    }
}
