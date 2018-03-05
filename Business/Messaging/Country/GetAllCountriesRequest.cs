using DataAccess;

namespace Business.Messaging.Country
{
    public class GetAllCountriesRequest : BaseRequest
    {
        public GetAllCountriesRequest(Context context): base(context)
        {            
        }
    }
}