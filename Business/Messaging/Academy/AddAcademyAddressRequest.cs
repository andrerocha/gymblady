using DataAccess;

namespace Business.Messaging.Academy
{
    public class AddAcademyAddressRequest : BaseRequest
    {
        public AddAcademyAddressRequest(Context context) : base(context)
        {
        }

        public Entities.AcademyAddress AcademyAddress { get; set; }
    }
}