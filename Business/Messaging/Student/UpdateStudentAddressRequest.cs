using DataAccess;

namespace Business.Messaging.Student
{
    public class UpdateStudentAddressRequest : BaseRequest
    {
        public UpdateStudentAddressRequest(Context context) : base(context)
        {
        }

        public Entities.StudentAddress StudentAddress { get; set; }
    }
}