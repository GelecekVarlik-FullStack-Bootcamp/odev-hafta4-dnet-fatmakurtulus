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
    public class DepartmentManager : GenericManager<Departmant, DtoDepartmant>, IDepartmantService
    {
        public readonly IDepartmantService departmantService;
        public DepartmentManager(IServiceProvider service):base (service)
        {
            departmantService = service.GetService<IDepartmantService>();
                
        }
    }
}
