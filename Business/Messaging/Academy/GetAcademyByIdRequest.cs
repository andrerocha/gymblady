using DataAccess;

namespace Business.Messaging.Academy
{
    public class GetAcademyByIdRequest : BaseRequest
    {
        public GetAcademyByIdRequest(Context context) : base(context)
        {
        }

        public int IdAcademy { get; set; }
    }
}