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

                //Default Master Detail Page with Fresh MVVM
                //var navigationContainer = new FreshMasterDetailNavigationContainer();
                //navigationContainer.Init("Menu");
                //navigationContainer.AddPage<Detail1PageModel>("First Page", null);
                //navigationContainer.AddPage<Detail2PageModel>("Second Page", null);

                //To create Custom Master Detail Page with Fresh MVVM
                var page = FreshPageModelResolver.ResolvePageModel<MainPageModel>();
                var navigationContainer = new FreshNavigationContainer(page);

                MainPage = navigationContainer;
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
