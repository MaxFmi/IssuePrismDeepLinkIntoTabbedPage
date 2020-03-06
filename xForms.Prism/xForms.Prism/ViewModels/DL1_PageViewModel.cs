using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace xForms.Prism.ViewModels
{
    public class DL1_PageViewModel : ViewModelBase
    {
        public DL1_PageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "DL 1";
        }
    }
}
