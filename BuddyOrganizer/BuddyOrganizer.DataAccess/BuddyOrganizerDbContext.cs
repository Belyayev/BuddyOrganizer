using BuddyOrganizer.Model;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace BuddyOrganizer.DataAccess
{
    public class BuddyOrganizerDbContext : DbContext
    {
        public BuddyOrganizerDbContext():base("BuddyOrganizerDb")
        {

        }
        public DbSet<Buddy> Buddies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
