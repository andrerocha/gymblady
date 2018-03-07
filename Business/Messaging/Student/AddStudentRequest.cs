using DataAccess;

namespace Business.Messaging.Student
{
    public class AddStudentRequest : BaseRequest
    {
        public AddStudentRequest(Context context) : base(context)
        {
        }

        public Entities.Student Student { get; set; }
    }
}