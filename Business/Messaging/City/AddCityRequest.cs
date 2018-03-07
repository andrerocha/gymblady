using DataAccess;

namespace Business.Messaging.City
{
    public class AddCityRequest : BaseRequest
    {
        public AddCityRequest(Context context) : base(context)
        {
        }

        public Entities.City City { get; set; }
    }
}