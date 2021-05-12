using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TblUser
    {
        public TblUser()
        {
            TblOrderApplies = new HashSet<TblOrderApply>();
            TblOrders = new HashSet<TblOrder>();
        }

        public int AutoUserId { get; set; }
        public string NickName { get; set; }
        public string UserPassword { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserAddress { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int? UpdateId { get; set; }

        public virtual TblUpdate Update { get; set; }
        public virtual ICollection<TblOrderApply> TblOrderApplies { get; set; }
        public virtual ICollection<TblOrder> TblOrders { get; set; }
    }
}
