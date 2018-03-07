using DataAccess;

namespace Business.Messaging.Team
{
    public class AddTeamRequest : BaseRequest
    {
        public AddTeamRequest(Context context) : base(context)
        {
        }

        public Entities.Team Team { get; set; }
    }
}