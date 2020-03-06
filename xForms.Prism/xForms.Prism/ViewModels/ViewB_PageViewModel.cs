using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace xForms.Prism.ViewModels
{
    class ViewB_PageViewModel : ViewModelBase
    {
        public ViewB_PageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "1_ViewB";
        }
    }
}
