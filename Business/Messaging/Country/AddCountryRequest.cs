using DataAccess;

namespace Business.Messaging.Country
{
    public class AddCountryRequest : BaseRequest
    {
        public AddCountryRequest(Context context) : base(context)
        {
        }

        public Entities.Country Country { get; set; }
    }
}