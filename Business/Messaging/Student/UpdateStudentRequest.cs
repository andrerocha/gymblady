using DataAccess;

namespace Business.Messaging.Student
{
    public class UpdateStudentRequest : BaseRequest
    {
        public UpdateStudentRequest(Context context) : base(context)
        {
        }

        public Entities.Student Student { get; set; }
    }
}