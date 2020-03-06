using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace xForms.Prism.ViewModels
{
    class ViewA_PageViewModel : ViewModelBase
    {
        public ViewA_PageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "1_ViewA";
        }
    }
}
