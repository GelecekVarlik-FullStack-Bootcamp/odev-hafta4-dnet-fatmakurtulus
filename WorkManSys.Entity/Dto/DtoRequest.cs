using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkManSys.Entity.Base;

namespace WorkManSys.Entity.Dto
{
    public class DtoRequest :DtoBase
    {
        public DtoRequest()
        {

        }
        public int ReqId { get; set; }
        public string ReqHeader { get; set; }
        public int ReqSubjectid { get; set; }
        public DateTime ReqStartdate { get; set; }
        public DateTime ReqFinishdate { get; set; }
        public DateTime ReqCreationdate { get; set; }
        public int ReqStatusid { get; set; }
        public int ReqDepartmantid { get; set; }
        public string ReqDetails { get; set; }
        public int ReqOwnerid { get; set; }

    }
}
