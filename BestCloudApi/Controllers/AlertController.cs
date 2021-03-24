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
    public class AlertController : ApiController
    {
        public object JsonConver { get; private set; }

        [HttpPost]
        [Route("alert")]
        public IHttpActionResult Post(Person p)
        {
            string data = JsonConvert.SerializeObject(p);
            WebClient client = new WebClient();
            client.Encoding = System.Text.Encoding.UTF8;
            string reply = client.UploadString("https://webhook.site/ebb901bd-f2f3-419f-8ee2-75b2c138200a", data);
            Console.WriteLine(reply);

            return Ok(reply);
        }

    }
}
