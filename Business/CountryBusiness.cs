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
    }
}