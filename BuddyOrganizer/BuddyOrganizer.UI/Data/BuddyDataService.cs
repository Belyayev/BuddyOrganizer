using BuddyOrganizer.DataAccess;
using BuddyOrganizer.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace BuddyOrganizer.UI.Data
{
    public class BuddyDataService : IBuddyDataService
    {
        private Func<BuddyOrganizerDbContext> _contextCreator;

        public BuddyDataService(System.Func<BuddyOrganizerDbContext> contextCreator)
        {
            _contextCreator = contextCreator;
        }
        public async Task<List<Buddy>> GetAllAsync()
        {
            using(var ctx = _contextCreator())
            {
                return await ctx.Buddies.AsNoTracking().ToListAsync();
            }
        }
    }
}
