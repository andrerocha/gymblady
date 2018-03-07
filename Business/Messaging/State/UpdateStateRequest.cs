using DataAccess;

namespace Business.Messaging.State
{
    public class UpdateStateRequest : BaseRequest
    {
        public UpdateStateRequest(Context context) : base(context)
        {
        }

        public Entities.State State { get; set; }
    }
}