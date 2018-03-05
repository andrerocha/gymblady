using Business;
using Business.Messaging.Country;
using DataAccess;
using Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Api.Controllers
{
    public class CityController : Controller
    {
        Context _context;

        public CityController(Context context)
        {
            this._context = context;
        }

        [HttpGet]
        [Route("api/City/GetAllCities")]
        public List<City> GetAllCities()
        {
            var business = CityBusiness.Instance;
            var request = new GetAllCitiesRequest(this._context);
            var cities = business.GetAllCities(request);

            return cities;
        }

        [HttpGet]
        [Route("api/City/GetCityById")]
        public City GetCityById(int idCity)
        {
            City city = null;

            if (idCity > 0)
            {
                var business = CityBusiness.Instance;
                var request = new GetCityByIdRequest(this._context);
                request.IdCity = idCity;

                city = business.GetCityById(request);
            }

            return city;
        }

        [HttpPost]
        [Route("api/City/AddCity")]
        public City AddCity([FromBody]City city)
        {
            if (city != null)
            {
                var business = CityBusiness.Instance;
                var request = new AddCityRequest(this._context);
                request.City = city;

                city = business.AddCity(request);
            }

            return city;
        }
        
        [HttpPut]
        [Route("api/City/UpdateCity")]
        public City UpdateCity([FromBody]City city)
        {
            if (city != null)
            {
                var business = CityBusiness.Instance;
                var request = new UpdateCityRequest(this._context);
                request.City = city;

                city = business.UpdateCity(request);
            }

            return city;
        }
        
        [HttpDelete]
        [Route("api/City/DeleteCity")]
        public void DeleteCity(int idCity)
        {
            var business = CityBusiness.Instance;
            var request = new DeleteCityRequest(this._context);
            request.IdCity = idCity;

            business.DeleteCity(request);
        }
    }
}