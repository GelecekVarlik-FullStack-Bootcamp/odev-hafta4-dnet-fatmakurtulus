using System;
using System.Collections.Generic;
using WorkManSys.Entity.Base;

#nullable disable

namespace WorkManSys.Entity.Models
{
    public partial class Role : EntityBase
    
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
