using DataAccess;

namespace Business.Messaging.Academy
{
    public class DeleteAcademyAddressRequest : BaseRequest
    {
        public DeleteAcademyAddressRequest(Context context) : base(context)
        {
        }

        public int IdAcademyAddress { get; set; }
    }
}