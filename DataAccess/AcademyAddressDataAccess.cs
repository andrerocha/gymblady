using Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DataAccess
{
    public class AcademyAddressDataAccess : BaseDataAccess
    {
        public AcademyAddressDataAccess(Context context) : base(context)
        {
        }

        public IQueryable<AcademyAddress> GetAll()
        {
            return this.Context.AcademyAddress;
        }

        public IQueryable<AcademyAddress> GetById(int id)
        {
            return this.Context.AcademyAddress.Where(a => a.IdAcademyAddress == id);
        }

        public AcademyAddress Add(AcademyAddress academyAddress)
        {
            this.Context.Entry(academyAddress).State = EntityState.Added;
            this.Context.SaveChanges();

            return academyAddress;
        }

        public AcademyAddress Update(AcademyAddress academyAddress)
        {
            this.Context.Entry(academyAddress).State = EntityState.Modified;
            this.Context.SaveChanges();

            return academyAddress;
        }

        public void Delete(AcademyAddress academyAddress)
        {
            this.Context.Entry(academyAddress).State = EntityState.Deleted;
            this.Context.SaveChanges();
        }
    }
}