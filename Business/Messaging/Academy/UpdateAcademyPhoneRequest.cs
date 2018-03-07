using DataAccess;

namespace Business.Messaging.Academy
{
    public class UpdateAcademyPhoneRequest : BaseRequest
    {
        public UpdateAcademyPhoneRequest(Context context) : base(context)
        {
        }

        public Entities.AcademyPhone AcademyPhone { get; set; }
    }
}