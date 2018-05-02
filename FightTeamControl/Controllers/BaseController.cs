using DataAccess;
using Microsoft.AspNetCore.Mvc;

namespace FightTeamControl.Controllers
{
    public class BaseController : Controller
    {
        Context _context;        

        public BaseController(Context context)
        {
            this._context = context;
        }

        public Context Context { get { return this._context; } }
    }
}