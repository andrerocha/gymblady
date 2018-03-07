using DataAccess;

namespace Business.Messaging.Academy
{
    public class DeleteAcademyRequest : BaseRequest
    {
        public DeleteAcademyRequest(Context context) : base(context)
        {
        }

        public int IdAcademy { get; set; }
    }
}