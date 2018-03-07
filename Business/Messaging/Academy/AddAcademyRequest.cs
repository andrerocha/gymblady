using DataAccess;

namespace Business.Messaging.Academy
{
    public class AddAcademyRequest : BaseRequest
    {
        public AddAcademyRequest(Context context) : base(context)
        {
        }

        public Entities.Academy Academy { get; set; }
    }
}