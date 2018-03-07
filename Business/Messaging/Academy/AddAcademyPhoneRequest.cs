using DataAccess;

namespace Business.Messaging.Academy
{
    public class AddAcademyPhoneRequest : BaseRequest
    {
        public AddAcademyPhoneRequest(Context context) : base(context)
        {
        }

        public Entities.AcademyPhone AcademyPhone { get; set; }
    }
}