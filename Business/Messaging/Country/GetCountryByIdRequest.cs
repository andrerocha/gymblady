using DataAccess;

namespace Business.Messaging.Country
{
    public class GetCountryByIdRequest : BaseRequest
    {
        public GetCountryByIdRequest(Context context) : base(context)
        {
        }

        public int IdCountry { get; set; }
    }
}
