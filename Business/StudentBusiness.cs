using Business.Messaging.Student;
using DataAccess;
using Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Business
{
    public class StudentBusiness : BaseBusiness<StudentBusiness>
    {
        public List<Student> GetAllStudents(GetAllStudentsRequest request)
        {
            List<Student> students = null;

            if (request != null)
            {
                var dataAccess = new StudentDataAccess(request.Context);

                var studentsQuery = dataAccess.GetAll();                

                students = studentsQuery.ToList();
            }

            return students;
        }

        public Student GetStudentById(GetStudentByIdRequest request)
        {
            Student student = null;

            if (request != null)
            {
                var dataAccess = new StudentDataAccess(request.Context);

                var studentQuery = dataAccess.GetById(request.IdStudent);
                
                studentQuery = studentQuery.Include(a => a.Addresses);
                studentQuery = studentQuery.Include(a => a.Phones);

                student = studentQuery.FirstOrDefault();
            }

            return student;
        }

        public Student AddStudent(AddStudentRequest request)
        {
            Student student = null;

            if (request != null && request.Student != null)
            {
                var dataAccess = new StudentDataAccess(request.Context);

                student = dataAccess.Add(request.Student);
            }

            return student;
        }

        public Student UpdateStudent(UpdateStudentRequest request)
        {
            Student student = null;

            if (request != null && request.Student != null)
            {
                var dataAccess = new StudentDataAccess(request.Context);

                student = dataAccess.Update(request.Student);
            }

            return student;
        }

        public void DeleteStudent(DeleteStudentRequest request)
        {
            if (request != null)
            {
                var dataAccess = new StudentDataAccess(request.Context);

                var student = dataAccess.GetById(request.IdStudent);

                dataAccess.Delete(student.FirstOrDefault());
            }
        }

        public List<StudentAddress> GetAllStudentAddresses(GetAllStudentAddressesRequest request)
        {
            List<StudentAddress> addresses = null;

            if (request != null)
            {
                var dataAccess = new StudentAddressDataAccess(request.Context);

                var studentAddresses = dataAccess.GetAll();

                addresses = studentAddresses.ToList();
            }

            return addresses;
        }

        public StudentAddress GetStudentAddressById(GetStudentAddressByIdRequest request)
        {
            StudentAddress address = null;

            if (request != null)
            {
                var dataAccess = new StudentAddressDataAccess(request.Context);

                var studentAddressQuery = dataAccess.GetById(request.IdStudentAddress);

                studentAddressQuery = studentAddressQuery.Include(a => a.Student);

                address = studentAddressQuery.FirstOrDefault();
            }

            return address;
        }

        public StudentAddress AddStudentAddress(AddStudentAddressRequest request)
        {
            StudentAddress address = null;

            if (request != null && request.StudentAddress != null)
            {
                var dataAccess = new StudentAddressDataAccess(request.Context);

                address = dataAccess.Add(request.StudentAddress);
            }

            return address;
        }

        public StudentAddress UpdateStudentAddress(UpdateStudentAddressRequest request)
        {
            StudentAddress address = null;

            if (request != null && request.StudentAddress != null)
            {
                var dataAccess = new StudentAddressDataAccess(request.Context);

                address = dataAccess.Update(request.StudentAddress);
            }

            return address;
        }

        public void DeleteStudentAddress(DeleteStudentAddressRequest request)
        {
            if (request != null)
            {
                var dataAccess = new AcademyAddressDataAccess(request.Context);

                var address = dataAccess.GetById(request.IdStudentAddress);

                dataAccess.Delete(address.FirstOrDefault());
            }
        }

        public List<StudentPhone> GetAllStudentPhones(GetAllStudentPhonesRequest request)
        {
            List<StudentPhone> phones = null;

            if (request != null)
            {
                var dataAccess = new StudentPhoneDataAccess(request.Context);

                var studentPhonesQuery = dataAccess.GetAll();

                studentPhonesQuery = studentPhonesQuery.Include(s => s.Student);

                phones = studentPhonesQuery.ToList();
            }

            return phones;
        }

        public StudentPhone GetStudentPhoneById(GetStudentPhoneByIdRequest request)
        {
            StudentPhone phone = null;

            if (request != null)
            {
                var dataAccess = new StudentPhoneDataAccess(request.Context);

                var studentPhoneQuery = dataAccess.GetById(request.IdStudentPhone);

                studentPhoneQuery = studentPhoneQuery.Include(s => s.Student);

                phone = studentPhoneQuery.FirstOrDefault();
            }

            return phone;
        }

        public StudentPhone AddStudentPhone(AddStudentPhoneRequest request)
        {
            StudentPhone phone = null;

            if (request != null && request.StudentPhone != null)
            {
                var dataAccess = new StudentPhoneDataAccess(request.Context);

                phone = dataAccess.Add(request.StudentPhone);
            }

            return phone;
        }

        public StudentPhone UpdateStudentPhone(UpdateStudentPhoneRequest request)
        {
            StudentPhone phone = null;

            if (request != null && request.StudentPhone != null)
            {
                var dataAccess = new StudentPhoneDataAccess(request.Context);

                phone = dataAccess.Update(request.StudentPhone);
            }

            return phone;
        }

        public void DeleteStudentPhone(DeleteStudentPhoneRequest request)
        {
            if (request != null)
            {
                var dataAccess = new StudentPhoneDataAccess(request.Context);

                var phone = dataAccess.GetById(request.IdStudentPhone);

                dataAccess.Delete(phone.FirstOrDefault());
            }
        }
    }
}