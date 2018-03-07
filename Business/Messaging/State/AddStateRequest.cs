using DataAccess;

namespace Business.Messaging.State
{
    public class AddStateRequest : BaseRequest
    {
        public AddStateRequest(Context context) : base(context)
        {
        }

        public Entities.State State { get; set; }
    }
}