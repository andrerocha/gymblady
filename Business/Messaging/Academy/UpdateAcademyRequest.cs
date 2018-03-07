using DataAccess;

namespace Business.Messaging.Academy
{
    public class UpdateAcademyRequest : BaseRequest
    {
        public UpdateAcademyRequest(Context context) : base(context)
        {
        }

        public Entities.Academy Academy { get; set; }
    }
}