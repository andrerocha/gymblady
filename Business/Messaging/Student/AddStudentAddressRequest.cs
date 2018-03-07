using DataAccess;

namespace Business.Messaging.Student
{
    public class AddStudentAddressRequest : BaseRequest
    {
        public AddStudentAddressRequest(Context context) : base(context)
        {
        }

        public Entities.StudentAddress StudentAddress { get; set; }
    }
}