using DataAccess;

namespace Business.Messaging.Team
{
    public class GetTeamByIdRequest : BaseRequest
    {
        public GetTeamByIdRequest(Context context) : base(context)
        {
        }

        public int IdTeam { get; set; }
    }
}