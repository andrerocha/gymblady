using Business;
using Business.Messaging;
using DataAccess;
using Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Api.Controllers
{
    public class CountryController : Controller
    {
        Context _context;

        public CountryController(Context context)
        {
            this._context = context;
        }

        [HttpGet]
        [Route("api/Country/GetAllCountries")]
        public List<Country> GetAllCountries()
        {
            var business = CountryBusiness.Instance;
            var request = new GetAllCountriesRequest(this._context);
            var countries = business.GetAllCountries(request);

            return countries;
        }

        [HttpGet]
        [Route("api/Country/GetCountryById")]
        public Country GetCountryById(int id)
        {
            var business = CountryBusiness.Instance;
            var request = new GetCountryByIdRequest(this._context);
            request.IdCountry = id;

            var country = business.GetCountryById(request);

            return country;
        }

        [HttpPost]
        [Route("api/Country/AddCountry")]
        public Country AddCountry([FromBody]Country country)
        {
            var business = CountryBusiness.Instance;
            var request = new AddCountryRequest(this._context);
            request.Country = country;

            country = business.AddCountry(request);

            return country;
        }
        
        [HttpPut]
        [Route("api/Country/UpdateCountry")]
        public Country UpdateCountry([FromBody]Country country)
        {
            var business = CountryBusiness.Instance;
            var request = new UpdateCountryRequest(this._context);
            request.Country = country;

            country = business.UpdateCountry(request);

            return country;
        }
        
        [HttpDelete]
        [Route("api/Country/DeleteCountry")]
        public void DeleteCountry(int idCountry)
        {
            var business = CountryBusiness.Instance;
            var request = new DeleteCountryRequest(this._context);
            request.IdCountry = idCountry;

            business.DeleteCountry(request);
        }
    }
}