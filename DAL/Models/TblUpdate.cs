using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TblUpdate
    {
        public TblUpdate()
        {
            TblOrderApplies = new HashSet<TblOrderApply>();
            TblUsers = new HashSet<TblUser>();
        }

        public int UpdateId { get; set; }
        public int? UpdateTypeId { get; set; }
        public int HighFreq { get; set; }

        public virtual TblUpdatesType UpdateType { get; set; }
        public virtual ICollection<TblOrderApply> TblOrderApplies { get; set; }
        public virtual ICollection<TblUser> TblUsers { get; set; }
    }
}
