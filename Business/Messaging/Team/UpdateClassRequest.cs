using DataAccess;

namespace Business.Messaging.Team
{
    public class UpdateTeamRequest : BaseRequest
    {
        public UpdateTeamRequest(Context context) : base(context)
        {
        }

        public Entities.Team Team { get; set; }
    }
}