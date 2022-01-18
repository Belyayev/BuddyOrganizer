using BuddyOrganizer.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BuddyOrganizer.UI.Data
{
    public interface IBuddyLookupDataService
    {
        Task<IEnumerable<LookupItem>> GetBuddyLookupAsync();
    }
}