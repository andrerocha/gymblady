using DataAccess;

namespace Business.Messaging.City
{
    public class UpdateCityRequest : BaseRequest
    {
        public UpdateCityRequest(Context context) : base(context)
        {
        }

        public Entities.City City { get; set; }
    }
}