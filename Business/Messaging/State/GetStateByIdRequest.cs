using DataAccess;

namespace Business.Messaging.State
{
    public class GetStateByIdRequest : BaseRequest
    {
        public GetStateByIdRequest(Context context) : base(context)
        {
        }

        public int IdState { get; set; }
    }
}