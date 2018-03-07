using DataAccess;

namespace Business.Messaging.Academy
{
    public class GetAcademyPhoneByIdRequest : BaseRequest
    {
        public GetAcademyPhoneByIdRequest(Context context) : base(context)
        {
        }

        public int IdAcademyPhone { get; set; }
    }
}