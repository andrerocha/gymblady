using Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DataAccess
{
    public class StudentAddressDataAccess : BaseDataAccess
    {
        public StudentAddressDataAccess(Context context) : base(context)
        {
        }

        public IQueryable<StudentAddress> GetAll()
        {
            return this.Context.StudentAddress;
        }

        public IQueryable<StudentAddress> GetById(int id)
        {
            return this.Context.StudentAddress.Where(s => s.IdStudentAddress == id);
        }

        public StudentAddress Add(StudentAddress studentAddress)
        {
            this.Context.Entry(studentAddress).State = EntityState.Added;
            this.Context.SaveChanges();

            return studentAddress;
        }

        public StudentAddress Update(StudentAddress studentAddress)
        {
            this.Context.Entry(studentAddress).State = EntityState.Modified;
            this.Context.SaveChanges();

            return studentAddress;
        }

        public void Delete(StudentAddress studentAddress)
        {
            this.Context.Entry(studentAddress).State = EntityState.Deleted;
            this.Context.SaveChanges();
        }
    }
}