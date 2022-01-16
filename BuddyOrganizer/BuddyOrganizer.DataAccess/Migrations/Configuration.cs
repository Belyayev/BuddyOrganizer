namespace BuddyOrganizer.DataAccess.Migrations
{
    using BuddyOrganizer.Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BuddyOrganizer.DataAccess.BuddyOrganizerDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BuddyOrganizer.DataAccess.BuddyOrganizerDbContext context)
        {
            context.Buddies.AddOrUpdate(
                f => f.FirstName,
                new Buddy { FirstName = "Mike", LastName = "White" },
                new Buddy { FirstName = "John", LastName = "Doe" },
                new Buddy { FirstName = "Kate", LastName = "White" },
                new Buddy { FirstName = "Allan", LastName = "Smith" }
                );
        }
    }
}
