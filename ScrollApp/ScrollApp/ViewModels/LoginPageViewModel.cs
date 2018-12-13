using Prism.Navigation;

namespace ScrollApp.ViewModels
{
    public class LoginPageViewModel : ViewModelBase
    {
        public LoginPageViewModel(INavigationService navigationService)
            :base(navigationService)
        {
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            // this simulates autologin
            NavigationService.NavigateAsync("../HomePage");
        }
    }
}
