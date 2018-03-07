using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace DataAccess
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        public DbSet<Team> Team { get; set; }
        public DbSet<Academy> Academy { get; set; }
        public DbSet<AcademyAddress> AcademyAddress { get; set; }
        public DbSet<AcademyPhone> AcademyPhone { get; set; }
        public DbSet<Class> Class { get; set; }                
        public DbSet<Student> Student { get; set; }
        public DbSet<StudentAddress> StudentAddress { get; set; }
        public DbSet<StudentPhone> StudentPhone { get; set; }        
        public DbSet<Country> Country { get; set; }
        public DbSet<State> State { get; set; }
        public DbSet<City> City { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {                       
            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            AddAuitInfo();
            return base.SaveChanges();
        }

        //public async Task SaveChangesAsync()
        //{
        //    AddAuitInfo();
        //    return await base.SaveChangesAsync();
        //}

        private void AddAuitInfo()
        {
            var entries = ChangeTracker.Entries().Where(x => x.Entity is BaseEntity && (x.State == EntityState.Added || x.State == EntityState.Modified));

            foreach (var entry in entries)
            {
                switch (entry.State)
                {
                    case EntityState.Modified:
                        ((BaseEntity)entry.Entity).Modified = DateTime.UtcNow;
                        break;

                    case EntityState.Added:
                        ((BaseEntity)entry.Entity).Created = DateTime.UtcNow;
                        break;                    
                }
            }
        }
    }
}