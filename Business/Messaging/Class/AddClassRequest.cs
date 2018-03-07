using DataAccess;

namespace Business.Messaging.Class
{
    public class AddClassRequest : BaseRequest
    {
        public AddClassRequest(Context context) : base(context)
        {
        }

        public Entities.Class Class { get; set; }
    }
}