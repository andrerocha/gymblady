using DataAccess;

namespace Business.Messaging
{
    public class GetCountryByIdRequest : BaseRequest
    {
        public GetCountryByIdRequest(Context context) : base(context)
        {
        }

        public int IdCountry { get; set; }
    }
}
