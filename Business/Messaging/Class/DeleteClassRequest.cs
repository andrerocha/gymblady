using DataAccess;

namespace Business.Messaging.Class
{
    public class DeleteClassRequest : BaseRequest
    {
        public DeleteClassRequest(Context context) : base(context)
        {
        }

        public int IdClass { get; set; }
    }
}