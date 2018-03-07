using DataAccess;

namespace Business.Messaging.Team
{
    public class DeleteTeamRequest : BaseRequest
    {
        public DeleteTeamRequest(Context context) : base(context)
        {
        }

        public int IdTeam { get; set; }
    }
}