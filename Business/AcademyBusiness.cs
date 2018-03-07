using Business.Messaging.Academy;
using DataAccess;
using Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Business
{
    public class AcademyBusiness : BaseBusiness<AcademyBusiness>
    {
        public List<Academy> GetAllAcademies(GetAllAcademiesRequest request)
        {
            List<Academy> academies = null;

            if (request != null)
            {
                var dataAccess = new AcademyDataAccess(request.Context);

                var academiesQuery = dataAccess.GetAll();

                academiesQuery = academiesQuery.Include(a => a.Team);

                academies = academiesQuery.ToList();
            }

            return academies;
        }

        public Academy GetAcademyById(GetAcademyByIdRequest request)
        {
            Academy academy = null;

            if (request != null)
            {
                var dataAccess = new AcademyDataAccess(request.Context);

                var academyQuery = dataAccess.GetById(request.IdAcademy);

                academyQuery = academyQuery.Include(a => a.Team);
                academyQuery = academyQuery.Include(a => a.Addresses);
                academyQuery = academyQuery.Include(a => a.Phones);

                academy = academyQuery.FirstOrDefault();
            }

            return academy;
        }

        public Academy AddAcademy(AddAcademyRequest request)
        {
            Academy academy = null;

            if (request != null && request.Academy != null)
            {
                var dataAccess = new AcademyDataAccess(request.Context);

                academy = dataAccess.Add(request.Academy);
            }

            return academy;
        }

        public Academy UpdateAcademy(UpdateAcademyRequest request)
        {
            Academy academy = null;

            if (request != null && request.Academy != null)
            {
                var dataAccess = new AcademyDataAccess(request.Context);

                academy = dataAccess.Update(request.Academy);
            }

            return academy;
        }

        public void DeleteAcademy(DeleteAcademyRequest request)
        {
            if (request != null)
            {
                var dataAccess = new AcademyDataAccess(request.Context);

                var academy = dataAccess.GetById(request.IdAcademy);

                dataAccess.Delete(academy.FirstOrDefault());
            }
        }

        public List<AcademyAddress> GetAllAcademyAddresses(GetAllAcademyAddressesRequest request)
        {
            List<AcademyAddress> addresses = null;

            if (request != null)
            {
                var dataAccess = new AcademyAddressDataAccess(request.Context);

                var academyAddressesQuery = dataAccess.GetAll();

                addresses = academyAddressesQuery.ToList();
            }

            return addresses;
        }

        public AcademyAddress GetAcademyAddressById(GetAcademyAddressByIdRequest request)
        {
            AcademyAddress address = null;

            if (request != null)
            {
                var dataAccess = new AcademyAddressDataAccess(request.Context);

                var academyAddressQuery = dataAccess.GetById(request.IdAcademyAddress);

                academyAddressQuery = academyAddressQuery.Include(a => a.Academy);

                address = academyAddressQuery.FirstOrDefault();
            }

            return address;
        }

        public AcademyAddress AddAcademyAddress(AddAcademyAddressRequest request)
        {
            AcademyAddress address = null;

            if (request != null && request.AcademyAddress != null)
            {
                var dataAccess = new AcademyAddressDataAccess(request.Context);

                address = dataAccess.Add(request.AcademyAddress);
            }

            return address;
        }

        public AcademyAddress UpdateAcademyAddress(UpdateAcademyAddressRequest request)
        {
            AcademyAddress address = null;

            if (request != null && request.AcademyAddress != null)
            {
                var dataAccess = new AcademyAddressDataAccess(request.Context);

                address = dataAccess.Update(request.AcademyAddress);
            }

            return address;
        }

        public void DeleteAcademyAddress(DeleteAcademyAddressRequest request)
        {
            if (request != null)
            {
                var dataAccess = new AcademyAddressDataAccess(request.Context);

                var address = dataAccess.GetById(request.IdAcademyAddress);

                dataAccess.Delete(address.FirstOrDefault());
            }
        }

        public List<AcademyPhone> GetAllAcademyPhones(GetAllAcademyPhonesRequest request)
        {
            List<AcademyPhone> phones = null;

            if (request != null)
            {
                var dataAccess = new AcademyPhoneDataAccess(request.Context);

                var academyPhonesQuery = dataAccess.GetAll();

                academyPhonesQuery = academyPhonesQuery.Include(a => a.Academy);

                phones = academyPhonesQuery.ToList();
            }

            return phones;
        }

        public AcademyPhone GetAcademyPhoneById(GetAcademyPhoneByIdRequest request)
        {
            AcademyPhone phone = null;

            if (request != null)
            {
                var dataAccess = new AcademyPhoneDataAccess(request.Context);

                var academyPhoneQuery = dataAccess.GetById(request.IdAcademyPhone);

                academyPhoneQuery = academyPhoneQuery.Include(a => a.Academy);

                phone = academyPhoneQuery.FirstOrDefault();
            }

            return phone;
        }

        public AcademyPhone AddAcademyPhone(AddAcademyPhoneRequest request)
        {
            AcademyPhone phone = null;

            if (request != null && request.AcademyPhone != null)
            {
                var dataAccess = new AcademyPhoneDataAccess(request.Context);

                phone = dataAccess.Add(request.AcademyPhone);
            }

            return phone;
        }

        public AcademyPhone UpdateAcademyPhone(UpdateAcademyPhoneRequest request)
        {
            AcademyPhone phone = null;

            if (request != null && request.AcademyPhone != null)
            {
                var dataAccess = new AcademyPhoneDataAccess(request.Context);

                phone = dataAccess.Update(request.AcademyPhone);
            }

            return phone;
        }

        public void DeleteAcademyPhone(DeleteAcademyPhoneRequest request)
        {
            if (request != null)
            {
                var dataAccess = new AcademyPhoneDataAccess(request.Context);

                var phone = dataAccess.GetById(request.IdAcademyPhone);

                dataAccess.Delete(phone.FirstOrDefault());
            }
        }
    }
}