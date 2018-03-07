using Business.Messaging.City;
using DataAccess;
using Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Business
{
    public class CityBusiness : BaseBusiness<CityBusiness>
    {
        public List<City> GetAllCities(GetAllCitiesRequest request)
        {
            List<City> cities = null;

            if (request != null)
            {
                var dataAccess = new CityDataAccess(request.Context);

                var citiesQuery = dataAccess.GetAll();

                citiesQuery = citiesQuery.Include(c => c.State);

                cities = citiesQuery.ToList();
            }

            return cities;
        }

        public City GetCityById(GetCityByIdRequest request)
        {
            City city = null;

            if (request != null)
            {
                var dataAccess = new CityDataAccess(request.Context);

                var cityQuery = dataAccess.GetById(request.IdCity);

                cityQuery = cityQuery.Include(c => c.State);

                city = cityQuery.FirstOrDefault();
            }

            return city;
        }

        public City AddCity(AddCityRequest request)
        {
            City city = null;

            if (request != null && request.City != null)
            {
                var dataAccess = new CityDataAccess(request.Context);

                city = dataAccess.Add(request.City);
            }

            return city;
        }

        public City UpdateCity(UpdateCityRequest request)
        {
            City city = null;

            if (request != null && request.City != null)
            {
                var dataAccess = new CityDataAccess(request.Context);

                city = dataAccess.Update(request.City);
            }

            return city;
        }

        public void DeleteCity(DeleteCityRequest request)
        {
            if (request != null)
            {
                var dataAccess = new CityDataAccess(request.Context);

                var city = dataAccess.GetById(request.IdCity);

                dataAccess.Delete(city.FirstOrDefault());
            }
        }
    }
}