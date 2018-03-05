using Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DataAccess
{
    public class CityDataAccess : BaseDataAccess
    {
        public CityDataAccess(Context context) : base(context)
        {
        }

        public IQueryable<City> GetAll()
        {
            return this.Context.City;
        }

        public IQueryable<City> GetById(int id)
        {
            return this.Context.City.Where(c => c.IdCity == id);
        }

        public City Add(City city)
        {
            this.Context.Entry(city).State = EntityState.Added;
            this.Context.SaveChanges();

            return city;
        }

        public City Update(City city)
        {
            this.Context.Entry(city).State = EntityState.Modified;
            this.Context.SaveChanges();

            return city;
        }

        public void Delete(City city)
        {
            this.Context.Entry(city).State = EntityState.Deleted;
            this.Context.SaveChanges();
        }
    }
}