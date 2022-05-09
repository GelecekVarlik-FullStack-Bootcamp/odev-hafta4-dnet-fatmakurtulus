using System;
using System.Collections.Generic;
using WorkManSys.Entity.Base;


#nullable disable

namespace WorkManSys.Entity.Models
{
    public partial class Personal :EntityBase
    {
        public Personal()
        {
            Requests = new HashSet<Request>();
        }

        public int PerId { get; set; }
        public string PerName { get; set; }
        public string PerLastname { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public int DepartmentId { get; set; }
        public int RoleId { get; set; }

        public virtual Departmant Department { get; set; }
        public virtual Role Role { get; set; }
        public virtual ICollection<Request> Requests { get; set; }
    }
}
