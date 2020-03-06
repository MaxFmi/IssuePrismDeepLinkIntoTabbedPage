using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace xForms.Prism.ViewModels
{
    public class Tab2ContentPageViewModel : ViewModelBase
    {
        public Tab2ContentPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Tab 2 ContentPage";
        }
    }
}
