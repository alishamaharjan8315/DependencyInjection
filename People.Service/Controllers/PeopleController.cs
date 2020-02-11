using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using People.Service.Models;
using PeopleViewer.Common;

namespace People.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        IPeopleProvider _provider;
        //public PeopleController(IPeopleProvider provider)
        //{
        //    _provider = provider;
        //}

        [HttpGet]
        public IEnumerable<Person> Get()
        {
            return _provider.GetPeople(); 
        }
    }
}