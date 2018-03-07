using Business.Messaging.Team;
using DataAccess;
using Entities;
using System.Collections.Generic;
using System.Linq;

namespace Business
{
    public class TeamBusiness : BaseBusiness<TeamBusiness>
    {
        public List<Team> GetAllTeams(GetAllTeamsRequest request)
        {
            List<Team> teams = null;

            if (request != null)
            {
                var dataAccess = new TeamDataAccess(request.Context);

                var teamsQuery = dataAccess.GetAll();                

                teams = teamsQuery.ToList();
            }

            return teams;
        }

        public Team GetTeamById(GetTeamByIdRequest request)
        {
            Team team = null;

            if (request != null)
            {
                var dataAccess = new TeamDataAccess(request.Context);

                var academyQuery = dataAccess.GetById(request.IdTeam);

                team = academyQuery.FirstOrDefault();
            }

            return team;
        }

        public Team AddTeam(AddTeamRequest request)
        {
            Team team = null;

            if (request != null && request.Team != null)
            {
                var dataAccess = new TeamDataAccess(request.Context);

                team = dataAccess.Add(request.Team);
            }

            return team;
        }

        public Team UpdateTeam(UpdateTeamRequest request)
        {
            Team team = null;

            if (request != null && request.Team != null)
            {
                var dataAccess = new TeamDataAccess(request.Context);

                team = dataAccess.Update(request.Team);
            }

            return team;
        }

        public void DeleteTeam(DeleteTeamRequest request)
        {
            if (request != null)
            {
                var dataAccess = new TeamDataAccess(request.Context);

                var team = dataAccess.GetById(request.IdTeam);

                dataAccess.Delete(team.FirstOrDefault());
            }
        }
    }
}