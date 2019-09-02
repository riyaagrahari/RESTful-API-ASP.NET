﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Web_API_Demo.Controllers
{
    public class ValuesController : ApiController
    {
        static List<string> strings = new List<string>()
        {
            "value0","value1","value2"
        };
        // GET api/values
        public IEnumerable<string> Get()
        {
            return strings;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return strings[id];
        }

        // POST api/values
        public string Post([FromBody]string value)
        {
            strings.Add(value);
            return "Added successfully";
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
            strings[id] = value;
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            strings.RemoveAt(id);
        }
    }
}
