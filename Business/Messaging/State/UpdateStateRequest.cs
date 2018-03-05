using DataAccess;
using Entities;

namespace Business.Messaging.Country
{
    public class UpdateStateRequest : BaseRequest
    {
        public UpdateStateRequest(Context context) : base(context)
        {
        }

        public State State { get; set; }
    }
}