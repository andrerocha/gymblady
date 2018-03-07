using DataAccess;

namespace Business.Messaging.Academy
{
    public class DeleteAcademyPhoneRequest : BaseRequest
    {
        public DeleteAcademyPhoneRequest(Context context) : base(context)
        {
        }

        public int IdAcademyPhone { get; set; }
    }
}