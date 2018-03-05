using DataAccess;

namespace Business.Messaging.Country
{
    public class GetCityByIdRequest : BaseRequest
    {
        public GetCityByIdRequest(Context context) : base(context)
        {
        }

        public int IdCity { get; set; }
    }
}
