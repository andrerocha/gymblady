using Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DataAccess
{
    public class TeamDataAccess : BaseDataAccess
    {
        public TeamDataAccess(Context context) : base(context)
        {
        }

        public IQueryable<Team> GetAll()
        {
            return this.Context.Team;
        }

        public IQueryable<Team> GetById(int id)
        {
            return this.Context.Team.Where(a => a.IdTeam == id);
        }

        public Team Add(Team team)
        {
            this.Context.Entry(team).State = EntityState.Added;
            this.Context.SaveChanges();

            return team;
        }

        public Team Update(Team team)
        {
            this.Context.Entry(team).State = EntityState.Modified;
            this.Context.SaveChanges();

            return team;
        }

        public void Delete(Team team)
        {
            this.Context.Entry(team).State = EntityState.Deleted;
            this.Context.SaveChanges();
        }
    }
}