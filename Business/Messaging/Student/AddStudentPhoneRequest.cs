using DataAccess;

namespace Business.Messaging.Student
{
    public class AddStudentPhoneRequest : BaseRequest
    {
        public AddStudentPhoneRequest(Context context) : base(context)
        {
        }

        public Entities.StudentPhone StudentPhone { get; set; }
    }
}