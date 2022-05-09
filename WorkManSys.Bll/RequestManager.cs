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
    public class RequestManager: GenericManager<Request,DtoRequest>,IRequestService
    {
        public readonly IRequestRepository requestRepository;

        public RequestManager(IServiceProvider service) : base(service)
        {
            requestRepository = service.GetService<IRequestRepository>();
        }

    }
}
