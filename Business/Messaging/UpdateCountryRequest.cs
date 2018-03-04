using DataAccess;
using Entities;

namespace Business.Messaging
{
    public class UpdateCountryRequest : BaseRequest
    {
        public UpdateCountryRequest(Context context) : base(context)
        {
        }

        public Country Country { get; set; }
    }
}