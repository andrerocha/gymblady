using DataAccess;

namespace Business.Messaging.Country
{
    public class DeleteStateRequest : BaseRequest
    {
        public DeleteStateRequest(Context context) : base(context)
        {
        }

        public int IdState { get; set; }
    }
}