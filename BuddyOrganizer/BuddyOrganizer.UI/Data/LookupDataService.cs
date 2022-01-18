using BuddyOrganizer.DataAccess;
using BuddyOrganizer.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuddyOrganizer.UI.Data
{
    public class LookupDataService : IBuddyLookupDataService
    {
        private Func<BuddyOrganizerDbContext> _contextCreator;

        public LookupDataService(Func<BuddyOrganizerDbContext> contextCreator)
        {
            _contextCreator = contextCreator;
        }

        public async Task<IEnumerable<LookupItem>> GetBuddyLookupAsync()
        {
            using (var ctx = _contextCreator())
            {
                return await ctx.Buddies.AsNoTracking().Select(f => new LookupItem
                {
                    Id = f.Id,
                    DisplayMember = f.FirstName + " " + f.LastName
                }).ToListAsync();

            }
        }
    }
}
