using DataAccess;

namespace Business.Messaging.Student
{
    public class UpdateStudentPhoneRequest : BaseRequest
    {
        public UpdateStudentPhoneRequest(Context context) : base(context)
        {
        }

        public Entities.StudentPhone StudentPhone { get; set; }
    }
}