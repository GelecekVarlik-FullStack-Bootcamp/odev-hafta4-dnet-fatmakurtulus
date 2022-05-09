using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkManSys.Entity.Dto;
using WorkManSys.Entity.Models;
using WorkManSys.Interface;
using Microsoft.Extensions.DependencyInjection;
using WorkManSys.Dal.Abstract;

namespace WorkManSys.Bll
{
    public class RoleManager : GenericManager<Role,DtoRole>,IRoleService
    {
        public readonly IRoleRepository roleRepository;
        public RoleManager(IServiceProvider service) : base(service)
        {
            roleRepository = service.GetService<IRoleRepository>();

        }
    }
}
