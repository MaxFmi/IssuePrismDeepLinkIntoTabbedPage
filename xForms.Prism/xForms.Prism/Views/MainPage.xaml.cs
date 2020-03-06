using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
//using Xamarin.Forms.PlatformConfiguration;
//using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;

namespace xForms.Prism.Views
{
    public partial class MainPage : TabbedPage // Xamarin.Forms.
    {
        public MainPage()
        {
            InitializeComponent();

            //On<Android>().SetToolbarPlacement(ToolbarPlacement.Bottom);

        }
    }
}