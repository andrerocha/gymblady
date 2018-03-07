using DataAccess;

namespace Business.Messaging.Student
{
    public class GetStudentPhoneByIdRequest : BaseRequest
    {
        public GetStudentPhoneByIdRequest(Context context) : base(context)
        {
        }

        public int IdStudentPhone { get; set; }
    }
}