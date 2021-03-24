using BestCloudApi.Classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BestCloudApi.Controllers
{
    public class WhoamiController : ApiController
    {
        [HttpGet]
        [Route("whoami")]
        public Person Get(string firstName, string lastName)
        {
            Person p = new Person();
            p.firstName = firstName;
            p.lastName = lastName;
            string json = JsonConvert.SerializeObject(p);
            return p;
        }
    }
}
