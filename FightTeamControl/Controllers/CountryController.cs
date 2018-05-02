using Business;
using Business.Messaging.Country;
using DataAccess;
using Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FightTeamControl.Controllers
{
    public class CountryController : BaseController
    {
        public CountryController(Context context) : base(context) { }

        [HttpGet]
        [Route("api/Country/GetAllCountries")]
        public List<Country> GetAllCountries()
        {
            var business = CountryBusiness.Instance;
            var request = new GetAllCountriesRequest(this.Context);
            var countries = business.GetAllCountries(request);

            return countries;
        }

        [HttpGet]
        [Route("api/Country/GetCountryById")]
        public Country GetCountryById(int idCountry)
        {
            Country country = null;

            if (idCountry > 0)
            {
                var business = CountryBusiness.Instance;
                var request = new GetCountryByIdRequest(this.Context);
                request.IdCountry = idCountry;

                country = business.GetCountryById(request);
            }

            return country;
        }

        [HttpPost]
        [Route("api/Country/AddCountry")]
        public Country AddCountry([FromBody]Country country)
        {
            if (country != null)
            {
                var business = CountryBusiness.Instance;
                var request = new AddCountryRequest(this.Context);
                request.Country = country;

                country = business.AddCountry(request);
            }

            return country;
        }
        
        [HttpPut]
        [Route("api/Country/UpdateCountry")]
        public Country UpdateCountry([FromBody]Country country)
        {
            if (country != null)
            {
                var business = CountryBusiness.Instance;
                var request = new UpdateCountryRequest(this.Context);
                request.Country = country;

                country = business.UpdateCountry(request);
            }

            return country;
        }
        
        [HttpDelete]
        [Route("api/Country/DeleteCountry")]
        public void DeleteCountry(int idCountry)
        {
            var business = CountryBusiness.Instance;
            var request = new DeleteCountryRequest(this.Context);
            request.IdCountry = idCountry;

            business.DeleteCountry(request);
        }
    }
}