using Entities;
using System.Linq;

namespace DataAccess
{
    public class CountryDataAccess : BaseDataAccess
    {
        public CountryDataAccess(Context context): base(context)
        {            
        }

        public IQueryable<Country> GetAll()
        {           
            return this.Context.Country;
        }
    }
}