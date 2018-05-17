using DataAccess;
using Entities.Enum;
using FightTeamControl.Helpers;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace FightTeamControl.Controllers
{
    public class CoreController : BaseController
    {
        public CoreController(Context context) : base(context) { }

        [HttpGet]
        [Route("api/Core/GetAllBloodTypes")]
        public List<KeyValuePair<int, string>> GetAllBloodTypes()
        {
            return EnumHelper<BloodType>.GetItems().ToList();
        }
    }
}