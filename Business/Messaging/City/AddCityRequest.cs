using DataAccess;
using Entities;

namespace Business.Messaging.Country
{
    public class AddCityRequest : BaseRequest
    {
        public AddCityRequest(Context context) : base(context)
        {
        }

        public City City { get; set; }
    }
}