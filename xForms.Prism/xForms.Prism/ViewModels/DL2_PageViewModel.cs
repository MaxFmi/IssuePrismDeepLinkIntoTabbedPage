using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace xForms.Prism.ViewModels
{
    public class DL2_PageViewModel : ViewModelBase
    {
        public DL2_PageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "DL 2";
        }
    }
}
