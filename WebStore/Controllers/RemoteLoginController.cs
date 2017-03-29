using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebStore.Models;

namespace WebStore.Controllers
{
    public class RemoteLoginController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "Hi", "There" };
        }

        // GET api/<controller>/5
        public RemoteLoginModel Get(int id)
        {
            RemoteLoginModel m = new RemoteLoginModel() {Email="Email Address",Password="User Password"};
            return m;
        }


        // Post api/<controller>
        [HttpPost]
        public string Post( RemoteLoginModel user)
        {
            string valid = "unauthorized";
            return valid;
        }

        // POST api/<controller>
        //public void Post([FromBody]string value)
        //{
        //}

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}