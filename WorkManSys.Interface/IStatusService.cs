using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkManSys.Entity.Dto;
using WorkManSys.Entity.Models;

namespace WorkManSys.Interface
{
    public interface IStatusService :IGenericService<Status,DtoStatus>
    {
    }
}
