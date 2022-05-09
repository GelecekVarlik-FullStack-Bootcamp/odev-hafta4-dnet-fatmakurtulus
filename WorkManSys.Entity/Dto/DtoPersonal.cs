using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkManSys.Entity.Base;

namespace WorkManSys.Entity.Dto
{
    public class DtoPersonal :DtoBase
    {
        public DtoPersonal()
        {

        }
        public int PerId { get; set; }
        public string PerName { get; set; }
        public string PerLastname { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public int DepartmentId { get; set; }
        public int RoleId { get; set; }
    }
}
