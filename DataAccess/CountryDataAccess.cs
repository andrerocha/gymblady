using Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DataAccess
{
    public class CountryDataAccess : BaseDataAccess
    {
        public CountryDataAccess(Context context) : base(context)
        {
        }

        public IQueryable<Country> GetAll()
        {
            return this.Context.Country;
        }

        public IQueryable<Country> GetById(int id)
        {
            return this.Context.Country.Where(c => c.IdCountry == id);
        }

        public Country Add(Country country)
        {
            this.Context.Entry(country).State = EntityState.Added;
            this.Context.SaveChanges();

            return country;
        }

        public Country Update(Country country)
        {
            this.Context.Entry(country).State = EntityState.Modified;
            this.Context.SaveChanges();

            return country;
        }

        public void Delete(Country country)
        {
            this.Context.Entry(country).State = EntityState.Deleted;
            this.Context.SaveChanges();           
        }
    }
}