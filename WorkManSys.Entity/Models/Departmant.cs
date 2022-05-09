using System;
using System.Collections.Generic;
using WorkManSys.Entity.Base;

#nullable disable

namespace WorkManSys.Entity.Models
{
    public partial class Departmant : EntityBase
    {
        public Departmant()
        {
            Personals = new HashSet<Personal>();
            Requests = new HashSet<Request>();
            Subjects = new HashSet<Subject>();
        }

        public int DepId { get; set; }
        public string DepName { get; set; }

        public virtual ICollection<Personal> Personals { get; set; }
        public virtual ICollection<Request> Requests { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; }
    }
}
