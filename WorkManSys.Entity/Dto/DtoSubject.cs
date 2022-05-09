using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkManSys.Entity.Base;

namespace WorkManSys.Entity.Dto
{
    public class DtoSubject : DtoBase
    {
        public DtoSubject()
        {

        }
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public int DeparmentId { get; set; }
    }
   

}
