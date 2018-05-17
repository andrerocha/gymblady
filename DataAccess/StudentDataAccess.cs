using Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DataAccess
{
    public class StudentDataAccess : BaseDataAccess
    {
        public StudentDataAccess(Context context) : base(context)
        {
        }

        public IQueryable<Student> GetAll()
        {
            return this.Context.Student;            
        }

        public IQueryable<Student> GetById(int id)
        {
            return this.Context.Student.Where(a => a.IdStudent == id);            
        }

        public Student Add(Student student)
        {
            this.Context.Entry(student).State = EntityState.Added;
            this.Context.SaveChanges();

            return student;
        }

        public Student Update(Student student)
        {
            this.Context.Entry(student).State = EntityState.Modified;
            this.Context.SaveChanges();

            return student;
        }

        public void Delete(Student student)
        {
            this.Context.Entry(student).State = EntityState.Deleted;
            this.Context.SaveChanges();
        }
    }
}