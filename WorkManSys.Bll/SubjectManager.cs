using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkManSys.Entity.Dto;
using WorkManSys.Entity.Models;
using WorkManSys.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace WorkManSys.Bll
{
    public class SubjectManager :GenericManager<Subject,DtoSubject>,ISubjectService
    {
        public readonly ISubjectService subjectService;
        public SubjectManager(IServiceProvider service) : base(service)
        {
            subjectService = service.GetService<ISubjectService>();

        }
    }
}
