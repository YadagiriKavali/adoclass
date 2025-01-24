using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UsingSqlServer.Models;

namespace UsingSqlServer.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        DatabaseConection db = new DatabaseConection();
        public IEnumerable<Emp> Get()
        {
           IEnumerable<Emp> emp= db.Emps.ToList();
            return emp;

        }

        // GET api/values/5
        public Emp Get(int id)
        {
            Emp emp = db.Emps.Where(x => x.EmpId == id).FirstOrDefault();
            return emp;
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
