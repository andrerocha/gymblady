using DataAccess;

namespace Business.Messaging.Country
{
    public class DeleteCityRequest : BaseRequest
    {
        public DeleteCityRequest(Context context) : base(context)
        {
        }

        public int IdCity { get; set; }
    }
}