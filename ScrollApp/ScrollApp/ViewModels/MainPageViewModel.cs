using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace ScrollApp.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public List<string> Artists { get; set; }
        public List<string> Albums { get; set; }
        public ICommand OpenFlexPageCommand { get; set; }
        public ICommand OpenFlexPageModalCommand { get; set; }

        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";
            OpenFlexPageCommand = new DelegateCommand(DoOpenFlexPage);
            OpenFlexPageModalCommand = new DelegateCommand(DoOpenFlexPageModal);
        }

        public override void OnNavigatingTo(INavigationParameters parameters)
        {
            Artists = new List<string>();
            Albums = new List<string>();
            Artists.AddRange(Enumerable.Range(0, 50).Select(_ => "https://via.placeholder.com/500"));
            Albums.AddRange(Enumerable.Range(0, 50).Select(_ => "https://via.placeholder.com/500"));
            base.OnNavigatingTo(parameters);
        }

        private void DoOpenFlexPage()
        {
            NavigationService.NavigateAsync("FlexPage", null, false);
        }

        private void DoOpenFlexPageModal()
        {
            NavigationService.NavigateAsync("FlexPage", null, true);
        }
    }
}


 