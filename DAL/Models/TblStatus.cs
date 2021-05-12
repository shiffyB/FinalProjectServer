using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TblStatus
    {
        public TblStatus()
        {
            TblOrders = new HashSet<TblOrder>();
        }

        public int StatusId { get; set; }
        public string StatusName { get; set; }

        public virtual ICollection<TblOrder> TblOrders { get; set; }
    }
}
