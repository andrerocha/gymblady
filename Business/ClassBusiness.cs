using Business.Messaging.Class;
using DataAccess;
using Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Business
{
    public class ClassBusiness : BaseBusiness<ClassBusiness>
    {
        public List<Class> GetAllClasses(GetAllClassesRequest request)
        {
            List<Class> classes = null;

            if (request != null)
            {
                var dataAccess = new ClassDataAccess(request.Context);

                var classesQuery = dataAccess.GetAll();

                classesQuery = classesQuery.Include(c => c.Academy);

                classes = classesQuery.ToList();
            }

            return classes;
        }

        public Class GetClassById(GetClassByIdRequest request)
        {
            Class item = null;

            if (request != null)
            {
                var dataAccess = new ClassDataAccess(request.Context);

                var classQuery = dataAccess.GetById(request.IdClass);

                classQuery = classQuery.Include(c => c.Academy);

                item = classQuery.FirstOrDefault();
            }

            return item;
        }

        public Class AddClass(AddClassRequest request)
        {
            Class item = null;

            if (request != null && request.Class != null)
            {
                var dataAccess = new ClassDataAccess(request.Context);

                item = dataAccess.Add(request.Class);
            }

            return item;
        }

        public Class UpdateClass(UpdateClassRequest request)
        {
            Class item = null;

            if (request != null && request.Class != null)
            {
                var dataAccess = new ClassDataAccess(request.Context);

                item = dataAccess.Update(request.Class);
            }

            return item;
        }

        public void DeleteClass(DeleteClassRequest request)
        {
            if (request != null)
            {
                var dataAccess = new ClassDataAccess(request.Context);

                var item = dataAccess.GetById(request.IdClass);

                dataAccess.Delete(item.FirstOrDefault());
            }
        }
    }
}