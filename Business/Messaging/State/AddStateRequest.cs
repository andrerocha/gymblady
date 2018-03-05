using DataAccess;
using Entities;

namespace Business.Messaging.Country
{
    public class AddStateRequest : BaseRequest
    {
        public AddStateRequest(Context context) : base(context)
        {
        }

        public State State { get; set; }
    }
}