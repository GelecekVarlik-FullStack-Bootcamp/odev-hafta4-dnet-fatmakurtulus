using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkManSys.Entity.Base;

namespace WorkManSys.Entity.Dto
{
    public class DtoDepartmant : DtoBase
    {
        public DtoDepartmant()
        {
                
        }
        public int DepId { get; set; }
        public string DepName { get; set; }
    }

   

}
