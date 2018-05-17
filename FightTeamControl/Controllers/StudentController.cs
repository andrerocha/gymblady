using Business;
using Business.Messaging.Student;
using DataAccess;
using Entities;
using Entities.Enum;
using FightTeamControl.Helpers;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FightTeamControl.Controllers
{
    public class StudentController : BaseController
    {
        public StudentController(Context context) : base(context) { }

        [HttpGet]
        [Route("api/Student/GetAllStudents")]
        public List<Student> GetAllStudents()
        {            
            var business = StudentBusiness.Instance;
            var request = new GetAllStudentsRequest(this.Context);
            var students = business.GetAllStudents(request);

            return students;
        }

        [HttpGet]
        [Route("api/Student/GetStudentById")]
        public Student GetStudentById(int idStudent)
        {
            Student student = null;

            if (idStudent > 0)
            {
                var business = StudentBusiness.Instance;
                var request = new GetStudentByIdRequest(this.Context);
                request.IdStudent = idStudent;

                student = business.GetStudentById(request);
            }

            return student;
        }

        [HttpPost]
        [Route("api/Student/AddStudent")]
        public Student AddStudent([FromBody]Student student)
        {
            if (student != null)
            {
                var business = StudentBusiness.Instance;
                var request = new AddStudentRequest(this.Context);
                request.Student = student;

                student = business.AddStudent(request);
            }

            return student;
        }

        [HttpPut]
        [Route("api/Student/UpdateStudent")]
        public Student UpdateStudent([FromBody]Student student)
        {
            if (student != null)
            {
                var business = StudentBusiness.Instance;
                var request = new UpdateStudentRequest(this.Context);
                request.Student = student;

                student = business.UpdateStudent(request);
            }

            return student;
        }

        [HttpDelete]
        [Route("api/Student/DeleteStudent")]
        public void DeleteStudent(int idStudent)
        {
            var business = StudentBusiness.Instance;
            var request = new DeleteStudentRequest(this.Context);
            request.IdStudent = idStudent;

            business.DeleteStudent(request);
        }

        [HttpGet]
        [Route("api/Student/GetAllStudentddresses")]
        public List<StudentAddress> GetAllStudentddresses()
        {
            var business = StudentBusiness.Instance;
            var request = new GetAllStudentAddressesRequest(this.Context);
            var addresses = business.GetAllStudentAddresses(request);

            return addresses;
        }

        [HttpGet]
        [Route("api/Student/GetStudentAddressById")]
        public StudentAddress GetStudentAddressById(int idStudentAddress)
        {
            StudentAddress address = null;

            if (idStudentAddress > 0)
            {
                var business = StudentBusiness.Instance;
                var request = new GetStudentAddressByIdRequest(this.Context);
                request.IdStudentAddress = idStudentAddress;

                address = business.GetStudentAddressById(request);
            }

            return address;
        }

        [HttpPost]
        [Route("api/Student/AddStudentAddress")]
        public StudentAddress AddStudentAddress([FromBody]StudentAddress address)
        {
            if (address != null)
            {
                var business = StudentBusiness.Instance;
                var request = new AddStudentAddressRequest(this.Context);
                request.StudentAddress = address;

                address = business.AddStudentAddress(request);
            }

            return address;
        }

        [HttpPut]
        [Route("api/Student/UpdateStudentAddress")]
        public StudentAddress UpdateStudentAddress([FromBody]StudentAddress address)
        {
            if (address != null)
            {
                var business = StudentBusiness.Instance;
                var request = new UpdateStudentAddressRequest(this.Context);
                request.StudentAddress = address;

                address = business.UpdateStudentAddress(request);
            }

            return address;
        }

        [HttpDelete]
        [Route("api/Student/DeleteStudentAddress")]
        public void DeleteStudentAddress(int idStudentAddress)
        {
            var business = StudentBusiness.Instance;
            var request = new DeleteStudentAddressRequest(this.Context);
            request.IdStudentAddress = idStudentAddress;

            business.DeleteStudentAddress(request);
        }

        [HttpGet]
        [Route("api/Academy/GetAllStudentPhones")]
        public List<StudentPhone> GetAllStudentPhones()
        {
            var business = StudentBusiness.Instance;
            var request = new GetAllStudentPhonesRequest(this.Context);
            var phones = business.GetAllStudentPhones(request);

            return phones;
        }

        [HttpGet]
        [Route("api/Student/GetStudentPhoneById")]
        public StudentPhone GetStudentPhoneById(int idStudentPhone)
        {
            StudentPhone phone = null;

            if (idStudentPhone > 0)
            {
                var business = StudentBusiness.Instance;
                var request = new GetStudentPhoneByIdRequest(this.Context);
                request.IdStudentPhone = idStudentPhone;

                phone = business.GetStudentPhoneById(request);
            }

            return phone;
        }

        [HttpPost]
        [Route("api/Student/AddStudentPhone")]
        public StudentPhone AddStudentPhone([FromBody]StudentPhone phone)
        {
            if (phone != null)
            {
                var business = StudentBusiness.Instance;
                var request = new AddStudentPhoneRequest(this.Context);
                request.StudentPhone = phone;

                phone = business.AddStudentPhone(request);
            }

            return phone;
        }

        [HttpPut]
        [Route("api/Student/UpdateStudentPhone")]
        public StudentPhone UpdateStudentPhone([FromBody]StudentPhone phone)
        {
            if (phone != null)
            {
                var business = StudentBusiness.Instance;
                var request = new UpdateStudentPhoneRequest(this.Context);
                request.StudentPhone = phone;

                phone = business.UpdateStudentPhone(request);
            }

            return phone;
        }

        [HttpDelete]
        [Route("api/Student/DeleteStudentPhone")]
        public void DeleteStudentPhone(int idStudentPhone)
        {
            var business = StudentBusiness.Instance;
            var request = new DeleteStudentPhoneRequest(this.Context);
            request.IdStudentPhone = idStudentPhone;

            business.DeleteStudentPhone(request);
        }
    }
}