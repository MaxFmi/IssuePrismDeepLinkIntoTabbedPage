using Prism.Navigation;
using System;
using Xamarin.Forms;
using xForms.Prism.ViewModels;

namespace xForms.Prism.Views
{
    public partial class Tab1ContentPage : ContentPage
    {
        public Tab1ContentPage()
        {
            InitializeComponent();

            DeepLinkCodeBehindButton.Clicked += clicked;
        }

        private async void clicked(object sender, EventArgs e) {
            var ViewModel = BindingContext as Tab1ContentPageViewModel;

            var result = await ViewModel._navigationService.NavigateAsync($"/NavigationPage/MainPage?{KnownNavigationParameters.SelectedTab}=Tab2ContentPage");
            if (result.Success)
            {
                Navigate(ViewModel);
                //ViewNavigationToViewA.Command = new Command(() => Navigate(ViewModel));
                //ViewNavigationToViewA.Command.Execute(null);


            }
        }

        private void Navigate(Tab1ContentPageViewModel ViewModel)
        {
            ViewNavigationToViewA.Command.Execute(null);
            //ViewModel._navigationService.NavigateTo(AppPages.DetailsPage);
        }
    }
}
