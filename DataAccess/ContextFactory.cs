using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace DataAccess
{
    public class ContextFactory : IDesignTimeDbContextFactory<Context>
    {
        public Context CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<Context>();
            optionsBuilder.UseSqlServer("Data Source=SQL5039.site4now.net;Initial Catalog=DB_A365DD_FightTeamControl;User Id=DB_A365DD_FightTeamControl_admin;Password=deda200989;");

            return new Context(optionsBuilder.Options);
        }
    }
}