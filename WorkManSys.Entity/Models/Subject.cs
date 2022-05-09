using System;
using System.Collections.Generic;
using WorkManSys.Entity.Base;

#nullable disable

namespace WorkManSys.Entity.Models
{
    public partial class Subject : EntityBase
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
