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

                // To set MainPage for the Application
                var page = FreshPageModelResolver.ResolvePageModel<MainPageModel>();
                var basicNavContainer = new FreshNavigationContainer(page);
                MainPage = basicNavContainer;
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
