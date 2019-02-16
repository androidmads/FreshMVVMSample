using FreshMvvm;
using System;

using Xamarin.Forms;

namespace FreshMVVMSample
{
    public partial class App : Application
    {
        public App()
        {
            try
            {
                InitializeComponent();

                var tabbedNavigation = new FreshTabbedNavigationContainer();
                tabbedNavigation.AddTab<Detail1PageModel>("First Tab", null);
                tabbedNavigation.AddTab<Detail2PageModel>("Second Tab", null);
                MainPage = tabbedNavigation;
            }
            catch (Exception ex)
            {

            }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
