using DataAccess;

namespace Business.Messaging.City
{
    public class GetAllCitiesRequest : BaseRequest
    {
        public GetAllCitiesRequest(Context context): base(context)
        {            
        }
    }
}