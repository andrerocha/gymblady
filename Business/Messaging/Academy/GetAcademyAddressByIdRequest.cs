using DataAccess;

namespace Business.Messaging.Academy
{
    public class GetAcademyAddressByIdRequest : BaseRequest
    {
        public GetAcademyAddressByIdRequest(Context context) : base(context)
        {
        }

        public int IdAcademyAddress { get; set; }
    }
}