using Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DataAccess
{
    public class StudentPhoneDataAccess : BaseDataAccess
    {
        public StudentPhoneDataAccess(Context context) : base(context)
        {
        }

        public IQueryable<StudentPhone> GetAll()
        {
            return this.Context.StudentPhone;
        }

        public IQueryable<StudentPhone> GetById(int id)
        {
            return this.Context.StudentPhone.Where(a => a.IdStudent == id);
        }

        public StudentPhone Add(StudentPhone studentPhone)
        {
            this.Context.Entry(studentPhone).State = EntityState.Added;
            this.Context.SaveChanges();

            return studentPhone;
        }

        public StudentPhone Update(StudentPhone studentPhone)
        {
            this.Context.Entry(studentPhone).State = EntityState.Modified;
            this.Context.SaveChanges();

            return studentPhone;
        }

        public void Delete(StudentPhone studentPhone)
        {
            this.Context.Entry(studentPhone).State = EntityState.Deleted;
            this.Context.SaveChanges();
        }
    }
}