using DataAccess;
using Entities;

namespace Business.Messaging.Country
{
    public class UpdateCityRequest : BaseRequest
    {
        public UpdateCityRequest(Context context) : base(context)
        {
        }

        public City City { get; set; }
    }
}