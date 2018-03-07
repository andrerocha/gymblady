using DataAccess;

namespace Business.Messaging.Class
{
    public class UpdateClassRequest : BaseRequest
    {
        public UpdateClassRequest(Context context) : base(context)
        {
        }

        public Entities.Class Class { get; set; }
    }
}