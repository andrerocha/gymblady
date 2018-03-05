using DataAccess;

namespace Business.Messaging.Country
{
    public class UpdateCountryRequest : BaseRequest
    {
        public UpdateCountryRequest(Context context) : base(context)
        {
        }

        public Entities.Country Country { get; set; }
    }
}