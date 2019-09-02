using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Web.Http;
using DemoDataAccess;

namespace Web_API_Demo.Controllers
{
    public class DemoController : ApiController
    {
        public IEnumerable<Demo> Get()
        {
            using(DemoDBEntities entities = new DemoDBEntities())
            {
                return entities.Demoes.ToList();

            }
        }

        public Demo Get(int id)
        {
            using (DemoDBEntities entities = new DemoDBEntities())
            {
                return entities.Demoes.FirstOrDefault(e => e.ID == id);

            }
        }
    }
}