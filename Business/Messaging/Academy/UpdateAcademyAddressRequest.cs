using DataAccess;

namespace Business.Messaging.Academy
{
    public class UpdateAcademyAddressRequest : BaseRequest
    {
        public UpdateAcademyAddressRequest(Context context) : base(context)
        {
        }

        public Entities.AcademyAddress AcademyAddress { get; set; }
    }
}