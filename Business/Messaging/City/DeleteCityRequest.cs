using DataAccess;

namespace Business.Messaging.City
{
    public class DeleteCityRequest : BaseRequest
    {
        public DeleteCityRequest(Context context) : base(context)
        {
        }

        public int IdCity { get; set; }
    }
}