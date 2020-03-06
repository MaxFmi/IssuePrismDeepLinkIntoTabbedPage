using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

// ToolbarPlacement top will be added to Xamarin.Forms. See https://github.com/xamarin/Xamarin.Forms/issues/7782

[assembly: ExportRenderer(typeof(MieleTabbedPage), typeof(MieleTabbedPageRenderer))]
namespace xForms.Prism.iOS.CustomRenderer
{
    public class MieleTabbedPageRenderer : TabbedPageRenderer
    {
        public MieleTabbedPageRenderer()
        {
        }

        public override void ViewWillLayoutSubviews()
        {
            base.ViewWillLayoutSubviews();

            nfloat tabSize = 44.0f;

            UIInterfaceOrientation orientation = UIApplication.SharedApplication.StatusBarOrientation;

            if (UIInterfaceOrientation.LandscapeLeft == orientation || UIInterfaceOrientation.LandscapeRight == orientation)
            {
                tabSize = 32.0f;
            }

            CGRect rect = this.View.Frame;
            rect.Y = this.NavigationController != null ? tabSize : tabSize + 20;
            this.View.Frame = rect;

            if (TabBarController != null)
            {
                CGRect tabFrame = this.TabBarController.TabBar.Frame;
                tabFrame.Height = tabSize;
                tabFrame.Y = this.NavigationController != null ? 64 : 20;
                this.TabBarController.TabBar.Frame = tabFrame;
                this.TabBarController.TabBar.BarTintColor = UIColor.Red;
            }
        }

        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);

            if (e.OldElement != null || Element == null)
            {
                return;
            }

            try
            {
                SetupUserInterface();
                SetupEventHandlers();
                SetupLiveCameraStream();
                AuthorizeCameraUse();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(@"            ERROR: ", ex.Message);
            }
        }
    }
}
