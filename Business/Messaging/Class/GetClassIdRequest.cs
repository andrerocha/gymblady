using DataAccess;

namespace Business.Messaging.Class
{
    public class GetClassByIdRequest : BaseRequest
    {
        public GetClassByIdRequest(Context context) : base(context)
        {
        }

        public int IdClass { get; set; }
    }
}