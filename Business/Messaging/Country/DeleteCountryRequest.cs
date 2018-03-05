using DataAccess;

namespace Business.Messaging.Country
{
    public class DeleteCountryRequest : BaseRequest
    {
        public DeleteCountryRequest(Context context) : base(context)
        {
        }

        public int IdCountry { get; set; }
    }
}