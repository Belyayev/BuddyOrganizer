using BuddyOrganizer.Model;
using System.Collections.Generic;

namespace BuddyOrganizer.UI.Data
{
    public class BuddyDataService : IBuddyDataService
    {
        public IEnumerable<Buddy> GetAll()
        {
            //TODO: Load data from real database
            yield return new Buddy { FirstName = "Mike", LastName = "Smith" };
            yield return new Buddy { FirstName = "Bob", LastName = "Marley" };
            yield return new Buddy { FirstName = "Tylor", LastName = "Gray" };
            yield return new Buddy { FirstName = "Kate", LastName = "Smith" };
        }
    }
}
