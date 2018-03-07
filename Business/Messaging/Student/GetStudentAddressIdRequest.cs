using DataAccess;

namespace Business.Messaging.Student
{
    public class GetStudentAddressByIdRequest : BaseRequest
    {
        public GetStudentAddressByIdRequest(Context context) : base(context)
        {
        }

        public int IdStudentAddress { get; set; }
    }
}