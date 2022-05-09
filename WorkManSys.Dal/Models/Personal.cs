using System;
using System.Collections.Generic;

#nullable disable

namespace WorkManSys.Dal.Models
{
    public partial class Personal
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
        public string Password { get; set; }

        public virtual Departmant Department { get; set; }
        public virtual Role Role { get; set; }
        public virtual ICollection<Request> Requests { get; set; }
    }
}
