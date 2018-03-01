using DataAccess;

namespace Business.Messaging
{
    public class BaseRequest
    {
        Context _context;

        public BaseRequest(Context context)
        {
            this._context = context;
        }

        public Context Context { get { return this._context; } }
    }
}