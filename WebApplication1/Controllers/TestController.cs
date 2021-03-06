﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class TestController : ApiController
    {
        // GET: api/Test
        public IEnumerable<string> Get()
        {
            string connectionString = !String.IsNullOrEmpty(Environment.GetEnvironmentVariable("DBConnection")) 
                                                ? Environment.GetEnvironmentVariable("DBConnection") 
                                                : System.Configuration.ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;

            return new string[] { "value1", "value2","value3","value4","value5",connectionString };
        }

        // GET: api/Test/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Test
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Test/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Test/5
        public void Delete(int id)
        {
        }
    }
}
