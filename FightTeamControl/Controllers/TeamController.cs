using Business;
using Business.Messaging.Team;
using DataAccess;
using Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FightTeamControl.Controllers
{
    public class TeamController : BaseController
    {
        public TeamController(Context context) : base(context) { }

        [HttpGet]
        [Route("api/Team/GetAllTeams")]
        public List<Team> GetAllTeams()
        {
            var business = TeamBusiness.Instance;
            var request = new GetAllTeamsRequest(this.Context);
            var classes = business.GetAllTeams(request);

            return classes;
        }

        [HttpGet]
        [Route("api/Team/GetTeamById")]
        public Team GetTeamById(int idTeam)
        {
            var business = TeamBusiness.Instance;
            var request = new GetTeamByIdRequest(this.Context);
            request.IdTeam = idTeam;

            var item = business.GetTeamById(request);

            return item;
        }

        [HttpPost]
        [Route("api/Team/AddTeam")]
        public Team AddTeam([FromBody]Team team)
        {
            if (team != null)
            {
                var business = TeamBusiness.Instance;
                var request = new AddTeamRequest(this.Context);
                request.Team = team;

                team = business.AddTeam(request);
            }

            return team;
        }

        [HttpPut]
        [Route("api/Team/UpdateTeam")]
        public Team UpdateTeam([FromBody]Team team)
        {
            if (team != null)
            {
                var business = TeamBusiness.Instance;
                var request = new UpdateTeamRequest(this.Context);
                request.Team = team;

                team = business.UpdateTeam(request);
            }

            return team;
        }

        [HttpDelete]
        [Route("api/Team/DeleteTeam")]
        public void DeleteTeam(int idTeam)
        {
            var business = TeamBusiness.Instance;
            var request = new DeleteTeamRequest(this.Context);
            request.IdTeam = idTeam;

            business.DeleteTeam(request);
        }
    }
}