using Prism;
using Prism.Ioc;
using xForms.Prism.ViewModels;
using xForms.Prism.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Prism.Navigation;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace xForms.Prism
{
    public partial class App
    {
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("NavigationPage/MainPage");
            //await NavigationService.NavigateAsync($"/NavigationPage/MainPage?{KnownNavigationParameters.SelectedTab}=Tab2ContentPage/ViewA_Page/ViewB_Page");

        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<ViewA_Page, ViewA_PageViewModel>();
            containerRegistry.RegisterForNavigation<ViewB_Page, ViewB_PageViewModel>();
            containerRegistry.RegisterForNavigation<ShopConnectPage, DlTabbedPageViewModel>();
            containerRegistry.RegisterForNavigation<SC1_Page, DL1_PageViewModel>();
            containerRegistry.RegisterForNavigation<SC2_Page, DL2_PageViewModel>();
            containerRegistry.RegisterForNavigation<Tab2ContentPage, Tab2ContentPageViewModel>();
            containerRegistry.RegisterForNavigation<Tab1ContentPage, Tab1ContentPageViewModel>();
        }
    }
}
