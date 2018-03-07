using Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DataAccess
{
    public class ClassDataAccess : BaseDataAccess
    {
        public ClassDataAccess(Context context) : base(context)
        {
        }

        public IQueryable<Class> GetAll()
        {
            return Context.Class;
        }

        public IQueryable<Class> GetById(int id)
        {
            return this.Context.Class.Where(c => c.IdClass == id);
        }

        public Class Add(Class entity)
        {
            this.Context.Entry(entity).State = EntityState.Added;
            this.Context.SaveChanges();

            return entity;
        }

        public Class Update(Class entity)
        {
            this.Context.Entry(entity).State = EntityState.Modified;
            this.Context.SaveChanges();

            return entity;
        }

        public void Delete(Class entity)
        {
            this.Context.Entry(entity).State = EntityState.Deleted;
            this.Context.SaveChanges();
        }
    }
}