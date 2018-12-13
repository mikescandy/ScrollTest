using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ScrollApp.ViewModels
{
    public class AnotherPageViewModel : ViewModelBase
    {
        public AnotherPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {

        }
    }
}
