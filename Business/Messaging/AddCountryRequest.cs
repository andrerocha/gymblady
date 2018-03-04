using DataAccess;
using Entities;

namespace Business.Messaging
{
    public class AddCountryRequest : BaseRequest
    {
        public AddCountryRequest(Context context) : base(context)
        {
        }

        public Country Country { get; set; }
    }
}