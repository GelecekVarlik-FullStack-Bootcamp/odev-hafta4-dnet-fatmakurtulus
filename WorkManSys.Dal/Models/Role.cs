using System;
using System.Collections.Generic;

#nullable disable

namespace WorkManSys.Dal.Models
{
    public partial class Role
    {
        public Role()
        {
            Personals = new HashSet<Personal>();
        }

        public int RoleId { get; set; }
        public string RoleName { get; set; }

        public virtual ICollection<Personal> Personals { get; set; }
    }
}
