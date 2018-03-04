using DataAccess;

namespace Business.Messaging
{
    public class DeleteCountryRequest : BaseRequest
    {
        public DeleteCountryRequest(Context context) : base(context)
        {
        }

        public int IdCountry { get; set; }
    }
}