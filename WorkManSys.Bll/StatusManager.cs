using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkManSys.Entity.Dto;
using WorkManSys.Entity.Models;
using WorkManSys.Interface;
using WorkManSys.Dal.Abstract;
using Microsoft.Extensions.DependencyInjection;


namespace WorkManSys.Bll
{
    public class StatusManager :GenericManager<Status,DtoStatus>,IStatusService
    {
        public readonly IStatusRepository statusRepository;
        public StatusManager(IServiceProvider service):base (service)
        {
            statusRepository = service.GetService<IStatusRepository>();
                
        }
    }
}
