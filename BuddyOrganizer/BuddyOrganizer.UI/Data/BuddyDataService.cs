using BuddyOrganizer.DataAccess;
using BuddyOrganizer.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BuddyOrganizer.UI.Data
{
    public class BuddyDataService : IBuddyDataService
    {
        private Func<BuddyOrganizerDbContext> _contextCreator;

        public BuddyDataService(System.Func<BuddyOrganizerDbContext> contextCreator)
        {
            _contextCreator = contextCreator;
        }
        public IEnumerable<Buddy> GetAll()
        {
            using(var ctx = _contextCreator())
            {
                return ctx.Buddies.AsNoTracking().ToList();
            }
        }
    }
}
