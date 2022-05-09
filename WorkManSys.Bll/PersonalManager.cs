using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkManSys.Dal.Abstract;
using WorkManSys.Entity.Dto;
using WorkManSys.Entity.IBase;
using WorkManSys.Entity.Models;
using WorkManSys.Interface;
using Microsoft.Extensions.DependencyInjection;


namespace WorkManSys.Bll
{
    public class PersonalManager : GenericManager<Personal, DtoPersonal>, IPersonalService
    {
        public readonly IPersonalRepository personalRepository;

        public PersonalManager(IServiceProvider service):base(service)
        {
            personalRepository = service.GetService<IPersonalRepository>();
                
        }

    }
}
