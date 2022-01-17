using BuddyOrganizer.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BuddyOrganizer.UI.Data
{
    public interface IBuddyDataService
    {
        Task<List<Buddy>> GetAllAsync();
    }
}