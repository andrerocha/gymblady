using Business.Messaging;
using DataAccess;
using Entities;
using System.Collections.Generic;
using System.Linq;

namespace Business
{
    public class CountryBusiness : BaseBusiness<CountryBusiness>
    {
        public List<Country> GetAllCountries(GetAllCountriesRequest request)
        {                      
            var dataAccess = new CountryDataAccess(request.Context);

            var countriesQuery = dataAccess.GetAll();

            return countriesQuery.ToList();
        }

        public Country GetCountryById(GetCountryByIdRequest request)
        {
            var dataAccess = new CountryDataAccess(request.Context);

            var countryQuery = dataAccess.GetById(request.IdCountry);

            return countryQuery.FirstOrDefault();
        }

        public Country AddCountry(AddCountryRequest request)
        {
            var dataAccess = new CountryDataAccess(request.Context);

            var country = dataAccess.Add(request.Country);

            return country;
        }

        public Country UpdateCountry(UpdateCountryRequest request)
        {
            var dataAccess = new CountryDataAccess(request.Context);

            var country = dataAccess.Update(request.Country);

            return country;
        }

        public void DeleteCountry(DeleteCountryRequest request)
        {
            var dataAccess = new CountryDataAccess(request.Context);

            var country = dataAccess.GetById(request.IdCountry);

            dataAccess.Delete(country.FirstOrDefault());            
        }
    }
}