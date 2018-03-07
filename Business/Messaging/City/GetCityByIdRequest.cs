using DataAccess;

namespace Business.Messaging.City
{
    public class GetCityByIdRequest : BaseRequest
    {
        public GetCityByIdRequest(Context context) : base(context)
        {
        }

        public int IdCity { get; set; }
    }
}
