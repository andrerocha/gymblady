using DataAccess;

namespace Business.Messaging.Student
{
    public class GetAllStudentsRequest : BaseRequest
    {
        public GetAllStudentsRequest(Context context): base(context)
        {            
        }
    }
}