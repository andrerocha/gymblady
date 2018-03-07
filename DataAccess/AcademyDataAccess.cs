using Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DataAccess
{
    public class AcademyDataAccess : BaseDataAccess
    {
        public AcademyDataAccess(Context context) : base(context)
        {
        }

        public IQueryable<Academy> GetAll()
        {
            return this.Context.Academy;
        }

        public IQueryable<Academy> GetById(int id)
        {
            return this.Context.Academy.Where(a => a.IdAcademy == id);
        }

        public Academy Add(Academy academy)
        {
            this.Context.Entry(academy).State = EntityState.Added;
            this.Context.SaveChanges();

            return academy;
        }

        public Academy Update(Academy academy)
        {
            this.Context.Entry(academy).State = EntityState.Modified;
            this.Context.SaveChanges();

            return academy;
        }

        public void Delete(Academy academy)
        {
            this.Context.Entry(academy).State = EntityState.Deleted;
            this.Context.SaveChanges();
        }
    }
}