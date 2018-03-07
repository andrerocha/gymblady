using DataAccess;

namespace Business.Messaging.Student
{
    public class DeleteStudentAddressRequest : BaseRequest
    {
        public DeleteStudentAddressRequest(Context context) : base(context)
        {
        }

        public int IdStudentAddress { get; set; }
    }
}