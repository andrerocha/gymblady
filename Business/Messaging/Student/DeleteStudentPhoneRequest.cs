using DataAccess;

namespace Business.Messaging.Student
{
    public class DeleteStudentPhoneRequest : BaseRequest
    {
        public DeleteStudentPhoneRequest(Context context) : base(context)
        {
        }

        public int IdStudentPhone { get; set; }
    }
}