using DataAccess;

namespace Business.Messaging.Student
{
    public class DeleteStudentRequest : BaseRequest
    {
        public DeleteStudentRequest(Context context) : base(context)
        {
        }

        public int IdStudent { get; set; }
    }
}