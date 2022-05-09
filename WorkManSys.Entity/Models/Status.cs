using System;
using System.Collections.Generic;
using WorkManSys.Entity.Base;

#nullable disable

namespace WorkManSys.Entity.Models
{
    public partial class Status : EntityBase
    
    {
        public Status()
        {
            Requests = new HashSet<Request>();
        }

        public int StatusId { get; set; }
        public string StatusName { get; set; }

        public virtual ICollection<Request> Requests { get; set; }
    }
}
