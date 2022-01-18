using BuddyOrganizer.Model;
using BuddyOrganizer.UI.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuddyOrganizer.UI.ViewModel
{
    public class NavigationViewModel : INavigationViewModel
    {
        private IBuddyLookupDataService _buddyLookupService;
        public NavigationViewModel(IBuddyLookupDataService buddyLookupService)
        {
            _buddyLookupService = buddyLookupService;
            Buddies = new ObservableCollection<LookupItem>();
        }

        public async Task LoadAsync()
        {
            var lookup = await _buddyLookupService.GetBuddyLookupAsync();
            Buddies.Clear();

            foreach (var item in lookup)
            {
                Buddies.Add(item);
            }
        }

        public ObservableCollection<LookupItem> Buddies { get; }

    }
}
