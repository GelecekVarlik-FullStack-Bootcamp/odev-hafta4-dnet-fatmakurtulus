using System;
using System.Collections.Generic;

#nullable disable

namespace WorkManSys.Dal.Models
{
    public partial class Request
    {
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

        public virtual Departmant ReqDepartmant { get; set; }
        public virtual Personal ReqOwner { get; set; }
        public virtual Status ReqStatus { get; set; }
        public virtual Subject ReqSubject { get; set; }
    }
}
