using Business;
using Business.Messaging.Academy;
using DataAccess;
using Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FightTeamControl.Controllers
{
    public class AcademyController : BaseController
    {
        public AcademyController(Context context) : base(context) { }

        [HttpGet]
        [Route("api/Academy/GetAllAcademies")]
        public List<Academy> GetAllAcademies()
        {
            var business = AcademyBusiness.Instance;
            var request = new GetAllAcademiesRequest(this.Context);
            var academies = business.GetAllAcademies(request);

            return academies;
        }

        [HttpGet]
        [Route("api/Academy/GetAcademyById")]
        public Academy GetAcademyById(int idAcademy)
        {
            Academy academy = null;

            if (idAcademy > 0)
            {
                var business = AcademyBusiness.Instance;
                var request = new GetAcademyByIdRequest(this.Context);
                request.IdAcademy = idAcademy;

                academy = business.GetAcademyById(request);
            }

            return academy;
        }

        [HttpPost]
        [Route("api/Academy/AddAcademy")]
        public Academy AddAcademy([FromBody]Academy academy)
        {
            if (academy != null)
            {
                var business = AcademyBusiness.Instance;
                var request = new AddAcademyRequest(this.Context);
                request.Academy = academy;

                academy = business.AddAcademy(request);
            }

            return academy;
        }

        [HttpPut]
        [Route("api/Academy/UpdateAcademy")]
        public Academy UpdateAcademy([FromBody]Academy academy)
        {
            if (academy != null)
            {
                var business = AcademyBusiness.Instance;
                var request = new UpdateAcademyRequest(this.Context);
                request.Academy = academy;

                academy = business.UpdateAcademy(request);
            }

            return academy;
        }

        [HttpDelete]
        [Route("api/Academy/DeleteAcademy")]
        public void DeleteAcademy(int idAcademy)
        {
            var business = AcademyBusiness.Instance;
            var request = new DeleteAcademyRequest(this.Context);
            request.IdAcademy = idAcademy;

            business.DeleteAcademy(request);
        }

        [HttpGet]
        [Route("api/Academy/GetAllAcademyAddresses")]
        public List<AcademyAddress> GetAllAcademyAddresses()
        {
            var business = AcademyBusiness.Instance;
            var request = new GetAllAcademyAddressesRequest(this.Context);
            var addresses = business.GetAllAcademyAddresses(request);

            return addresses;
        }

        [HttpGet]
        [Route("api/Academy/GetAcademyAddressById")]
        public AcademyAddress GetAcademyAddressById(int idAcademyAddress)
        {
            AcademyAddress address = null;

            if (idAcademyAddress > 0)
            {
                var business = AcademyBusiness.Instance;
                var request = new GetAcademyAddressByIdRequest(this.Context);
                request.IdAcademyAddress = idAcademyAddress;

                address = business.GetAcademyAddressById(request);
            }

            return address;
        }

        [HttpPost]
        [Route("api/Academy/AddAcademyAddress")]
        public AcademyAddress AddAcademyAddress([FromBody]AcademyAddress address)
        {
            if (address != null)
            {
                var business = AcademyBusiness.Instance;
                var request = new AddAcademyAddressRequest(this.Context);
                request.AcademyAddress = address;

                address = business.AddAcademyAddress(request);
            }

            return address;
        }

        [HttpPut]
        [Route("api/Academy/UpdateAcademyAddress")]
        public AcademyAddress UpdateAcademyAddress([FromBody]AcademyAddress address)
        {
            if (address != null)
            {
                var business = AcademyBusiness.Instance;
                var request = new UpdateAcademyAddressRequest(this.Context);
                request.AcademyAddress = address;

                address = business.UpdateAcademyAddress(request);
            }

            return address;
        }

        [HttpDelete]
        [Route("api/Academy/DeleteAcademyAddress")]
        public void DeleteAcademyAddress(int idAcademyAddress)
        {
            var business = AcademyBusiness.Instance;
            var request = new DeleteAcademyAddressRequest(this.Context);
            request.IdAcademyAddress = idAcademyAddress;

            business.DeleteAcademyAddress(request);
        }

        [HttpGet]
        [Route("api/Academy/GetAllAcademyPhones")]
        public List<AcademyPhone> GetAllAcademyPhones()
        {
            var business = AcademyBusiness.Instance;
            var request = new GetAllAcademyPhonesRequest(this.Context);
            var phones = business.GetAllAcademyPhones(request);

            return phones;
        }

        [HttpGet]
        [Route("api/Academy/GetAcademyPhoneById")]
        public AcademyPhone GetAcademyPhoneById(int idAcademyPhone)
        {
            AcademyPhone phone = null;

            if (idAcademyPhone > 0)
            {
                var business = AcademyBusiness.Instance;
                var request = new GetAcademyPhoneByIdRequest(this.Context);
                request.IdAcademyPhone = idAcademyPhone;

                phone = business.GetAcademyPhoneById(request);
            }

            return phone;
        }

        [HttpPost]
        [Route("api/Academy/AddAcademyPhone")]
        public AcademyPhone AddAcademyPhone([FromBody]AcademyPhone phone)
        {
            if (phone != null)
            {
                var business = AcademyBusiness.Instance;
                var request = new AddAcademyPhoneRequest(this.Context);
                request.AcademyPhone = phone;

                phone = business.AddAcademyPhone(request);
            }

            return phone;
        }

        [HttpPut]
        [Route("api/Academy/UpdateAcademyPhone")]
        public AcademyPhone UpdateAcademyPhone([FromBody]AcademyPhone phone)
        {
            if (phone != null)
            {
                var business = AcademyBusiness.Instance;
                var request = new UpdateAcademyPhoneRequest(this.Context);
                request.AcademyPhone = phone;

                phone = business.UpdateAcademyPhone(request);
            }

            return phone;
        }

        [HttpDelete]
        [Route("api/Academy/DeleteAcademyPhone")]
        public void DeleteAcademyPhone(int idAcademyPhone)
        {
            var business = AcademyBusiness.Instance;
            var request = new DeleteAcademyPhoneRequest(this.Context);
            request.IdAcademyPhone = idAcademyPhone;

            business.DeleteAcademyPhone(request);
        }
    }
}