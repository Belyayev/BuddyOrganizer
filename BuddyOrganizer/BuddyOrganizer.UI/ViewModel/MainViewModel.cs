using BuddyOrganizer.Model;
using BuddyOrganizer.UI.Data;
using System.Collections.ObjectModel;

namespace BuddyOrganizer.UI.ViewModel
{
    public class MainViewModel
    {
        private IBuddyDataService _buddyDataService;
        private Buddy _selectedBuddy;
        public MainViewModel(IBuddyDataService buddyDataService)
        {
            Buddies = new ObservableCollection<Buddy>();
            _buddyDataService = buddyDataService;
        }

        public void Load()
        {
            var buddies = _buddyDataService.GetAll();
            Buddies.Clear();
            foreach (var buddy in buddies)
            {
                Buddies.Add(buddy);
            }
        }
        public ObservableCollection<Buddy> Buddies { get; set; }

        public Buddy SelectedBuddy
        {
            get { return _selectedBuddy; }
            set { _selectedBuddy = value; }
        }

    }
}
