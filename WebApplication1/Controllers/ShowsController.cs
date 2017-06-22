using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Http;
using WebApplication1.Models;
using Newtonsoft.Json;

namespace SDV2.Controllers
{
    [System.Web.Http.RoutePrefix("api/shows")]
    public class ShowsController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
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

        //eg: GET api/shows/favorites
        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("favorites")]
        public string Favorites()
        {
            ShowModel product = new ShowModel()
            {ID=7, Name = "ABC", Genre = "Rock", Price = 100 };
            
            string json = JsonConvert.SerializeObject(product);

            return json;
        }
    }
}
