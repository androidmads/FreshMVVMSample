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

                //var tabbedNavigation = new FreshTabbedNavigationContainer();
                //tabbedNavigation.AddTab<MainPageModel>("First Tab", null);
                //tabbedNavigation.AddTab<SecondPageModel>("Second Tab", null);
                //MainPage = tabbedNavigation;

                var masterNavigation = new FreshMasterDetailNavigationContainer();
                masterNavigation.Init("Menu");
                masterNavigation.AddPage<Detail1PageModel>("First Page", null);
                masterNavigation.AddPage<Detail2PageModel>("Second Page", null);
                MainPage = masterNavigation;
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
