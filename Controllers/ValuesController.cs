using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace pdf_api_demo.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("AllowOrigin")]
    public class ValuesController : Controller
    {
        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get() => new string[] { "value1", "value2" };

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id) => $"value {id}";

        // POST api/values
        [HttpPost]
        public string Post(dynamic data)
        {
            try
            {
                return $"{data.fileText} Saved successsfully";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
