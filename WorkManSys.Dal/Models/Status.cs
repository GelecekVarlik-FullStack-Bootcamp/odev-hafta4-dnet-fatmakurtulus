using System;
using System.Collections.Generic;

#nullable disable

namespace WorkManSys.Dal.Models
{
    public partial class Status
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
