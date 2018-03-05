using DataAccess;

namespace Business.Messaging.Country
{
    public class GetStateByIdRequest : BaseRequest
    {
        public GetStateByIdRequest(Context context) : base(context)
        {
        }

        public int IdState { get; set; }
    }
}
