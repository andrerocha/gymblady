using Business;
using Business.Messaging.Class;
using DataAccess;
using Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Api.Controllers
{
    public class ClassController : BaseController
    {
        public ClassController(Context context) : base(context) { }

        [HttpGet]
        [Route("api/Class/GetAllClasses")]
        public List<Class> GetAllClasses()
        {
            var business = ClassBusiness.Instance;
            var request = new GetAllClassesRequest(this.Context);
            var classes = business.GetAllClasses(request);

            return classes;
        }

        [HttpGet]
        [Route("api/Class/GetClassById")]
        public Class GetClassById(int idClass)
        {
            var business = ClassBusiness.Instance;
            var request = new GetClassByIdRequest(this.Context);
            request.IdClass = idClass;

            var item = business.GetClassById(request);

            return item;
        }

        [HttpPost]
        [Route("api/Class/AddClass")]
        public Class AddClass([FromBody]Class item)
        {
            if (item != null)
            {
                var business = ClassBusiness.Instance;
                var request = new AddClassRequest(this.Context);
                request.Class = item;

                item = business.AddClass(request);
            }

            return item;
        }

        [HttpPut]
        [Route("api/Class/UpdateClass")]
        public Class UpdateClass([FromBody]Class item)
        {
            if (item != null)
            {
                var business = ClassBusiness.Instance;
                var request = new UpdateClassRequest(this.Context);
                request.Class = item;

                item = business.UpdateClass(request);
            }

            return item;
        }

        [HttpDelete]
        [Route("api/Class/DeleteClass")]
        public void DeleteClass(int idClass)
        {
            var business = ClassBusiness.Instance;
            var request = new DeleteClassRequest(this.Context);
            request.IdClass = idClass;

            business.DeleteClass(request);
        }
    }
}