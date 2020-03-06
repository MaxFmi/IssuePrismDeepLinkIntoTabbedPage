using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace xForms.Prism.ViewModels
{
    public class DlTabbedPageViewModel : ViewModelBase
    {
        public DlTabbedPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "ShopConnect Root";
        }
    }
}
