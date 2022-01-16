using BuddyOrganizer.Model;
using System.Collections.Generic;

namespace BuddyOrganizer.UI.Data
{
    public interface IBuddyDataService
    {
        IEnumerable<Buddy> GetAll();
    }
}