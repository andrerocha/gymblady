using DataAccess;

namespace Business.Messaging.Student
{
    public class GetStudentByIdRequest : BaseRequest
    {
        public GetStudentByIdRequest(Context context) : base(context)
        {
        }

        public int IdStudent { get; set; }
    }
}