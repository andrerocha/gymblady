namespace DataAccess
{
    public class BaseDataAccess
    {
        private Context _context;

        public Context Context { get { return this._context; } }

        public BaseDataAccess(Context context)
        {
            this._context = context;
        }
    }
}