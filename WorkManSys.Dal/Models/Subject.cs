using System;
using System.Collections.Generic;

#nullable disable

namespace WorkManSys.Dal.Models
{
    public partial class Subject
    {
        public Subject()
        {
            Requests = new HashSet<Request>();
        }

        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public int DeparmentId { get; set; }

        public virtual Departmant Deparment { get; set; }
        public virtual ICollection<Request> Requests { get; set; }
    }
}
