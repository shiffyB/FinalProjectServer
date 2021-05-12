using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TblUpdatesType
    {
        public TblUpdatesType()
        {
            TblUpdates = new HashSet<TblUpdate>();
        }

        public int UpdateTypeId { get; set; }
        public string UpdateTypeName { get; set; }

        public virtual ICollection<TblUpdate> TblUpdates { get; set; }
    }
}
