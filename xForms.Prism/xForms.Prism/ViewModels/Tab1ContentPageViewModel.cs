using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace xForms.Prism.ViewModels
{
    public class Tab1ContentPageViewModel : ViewModelBase
    {
        public INavigationService _navigationService;
        public DelegateCommand RelativeNavigationToViewACommand { get; set; }
        public DelegateCommand AbsoluteNavigationToViewACommand { get; set; }
        public DelegateCommand DeepLinkNavigationToViewACommand { get; set; }

        public Tab1ContentPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            _navigationService = navigationService;
            Title = "Tab 1 ContentPage";

            RelativeNavigationToViewACommand = new DelegateCommand(RelativeNavigationToViewA);
            AbsoluteNavigationToViewACommand = new DelegateCommand(AbsoluteNavigationToViewA);
            DeepLinkNavigationToViewACommand = new DelegateCommand(DeepLinkNavigationToViewA);
        }

        private void RelativeNavigationToViewA()
        {
            _navigationService.NavigateAsync("ViewA_Page");
        }

        private void AbsoluteNavigationToViewA()
        {
            _navigationService.NavigateAsync("/ViewA_Page");
        }

        private async void DeepLinkNavigationToViewA()
        {
            //_navigationService.NavigateAsync("/NavigationPage/ViewA_Page");
            //_navigationService.NavigateAsync($"/MainPage?{KnownNavigationParameters.SelectedTab}=Tab2ContentPage");
            //_navigationService.NavigateAsync($"/NavigationPage/MainPage?{KnownNavigationParameters.SelectedTab}=Tab2ContentPage");
            await _navigationService.NavigateAsync($"/NavigationPage/MainPage?{KnownNavigationParameters.SelectedTab}=Tab2ContentPage/ViewA_Page/ViewB_Page");
            //RelativeNavigationToViewACommand.Execute();


            /*            var result = await _navigationService.NavigateAsync($"/NavigationPage/MainPage?{KnownNavigationParameters.SelectedTab}=Tab2ContentPage");
                        if (result.Success)
                        {
                            //await Task.Delay(2000);
                            //RelativeNavigationToViewACommand.Execute();
                            //await _navigationService.NavigateAsync("ViewA_Page/ViewB_Page");
                        }
                        */
            //_navigationService.NavigateAsync($"/NavigationPage/MainPage?{KnownNavigationParameters.CreateTab}=Tab1ContentPage/ViewA_Page&{KnownNavigationParameters.CreateTab}=Tab2ContentPage");
        }
    }
}
