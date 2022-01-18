using BuddyOrganizer.Model;
using BuddyOrganizer.UI.Data;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace BuddyOrganizer.UI.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel(INavigationViewModel navigationViewModel)
        {
            NavigationViewModel = navigationViewModel;
        }

        public async Task LoadAsync()
        {
            await NavigationViewModel.LoadAsync();
        }

        public INavigationViewModel NavigationViewModel { get; }
    }
}
