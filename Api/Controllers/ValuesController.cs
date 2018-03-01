using System.Collections.Generic;
using System.Linq;
using Business;
using Business.Messaging;
using DataAccess;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        Context _context;

        public ValuesController(Context context)
        {
            this._context = context;
        }

        // GET api/values
        [HttpGet]
        public List<Country> Get()
        {
            //var countries = this._context.Country.ToList();

            var business = CountryBusiness.Instance;

            var request = new GetAllCountriesRequest(this._context);
            var countries = business.GetAllCountries(request);

            return countries;            
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}