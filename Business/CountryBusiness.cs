using Business.Messaging.Country;
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
            List<Country> countries = null;

            if (request != null)
            {
                var dataAccess = new CountryDataAccess(request.Context);

                var countriesQuery = dataAccess.GetAll();

                countries = countriesQuery.ToList();
            }

            return countries;
        }

        public Country GetCountryById(GetCountryByIdRequest request)
        {
            Country country = null;

            if (request != null)
            {
                var dataAccess = new CountryDataAccess(request.Context);

                var countryQuery = dataAccess.GetById(request.IdCountry);

                country = countryQuery.FirstOrDefault();
            }

            return country;
        }

        public Country AddCountry(AddCountryRequest request)
        {
            Country country = null;

            if (request != null && request.Country != null)
            {
                var dataAccess = new CountryDataAccess(request.Context);

                country = dataAccess.Add(request.Country);
            }

            return country;
        }

        public Country UpdateCountry(UpdateCountryRequest request)
        {
            Country country = null;

            if (request != null && request.Country != null)
            {
                var dataAccess = new CountryDataAccess(request.Context);

                country = dataAccess.Update(request.Country);
            }

            return country;
        }

        public void DeleteCountry(DeleteCountryRequest request)
        {
            if (request != null)
            {
                var dataAccess = new CountryDataAccess(request.Context);

                var country = dataAccess.GetById(request.IdCountry);

                dataAccess.Delete(country.FirstOrDefault());
            }
        }
    }
}