using Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DataAccess
{
    public class AcademyPhoneDataAccess : BaseDataAccess
    {
        public AcademyPhoneDataAccess(Context context) : base(context)
        {
        }

        public IQueryable<AcademyPhone> GetAll()
        {
            return this.Context.AcademyPhone;
        }

        public IQueryable<AcademyPhone> GetById(int id)
        {
            return this.Context.AcademyPhone.Where(a => a.IdAcademyPhone == id);
        }

        public AcademyPhone Add(AcademyPhone academyPhone)
        {
            this.Context.Entry(academyPhone).State = EntityState.Added;
            this.Context.SaveChanges();

            return academyPhone;
        }

        public AcademyPhone Update(AcademyPhone academyPhone)
        {
            this.Context.Entry(academyPhone).State = EntityState.Modified;
            this.Context.SaveChanges();

            return academyPhone;
        }

        public void Delete(AcademyPhone academyPhone)
        {
            this.Context.Entry(academyPhone).State = EntityState.Deleted;
            this.Context.SaveChanges();
        }
    }
}