using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkManSys.Entity.Dto;
using WorkManSys.Entity.Models;
using WorkManSys.Interface;
using WorkManSys.WebApi.Base;

namespace WorkManSys.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonalController : ApiBaseController<IPersonalService,Personal,DtoPersonal>
    {
        private readonly IPersonalService personalService;
        public PersonalController(IPersonalService personalService) :base(personalService)
        {
            this.personalService = personalService;
        }
        //[HttpGet("d")]

        
    }
}
