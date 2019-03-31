using FreshMvvm;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FreshMVVMSample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyMasterDetailPage : MasterDetailPage
    {
        public MyMasterDetailPage()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

            Master = FreshPageModelResolver.ResolvePageModel<MasterPageModel>();
            Detail = new NavigationPage(FreshPageModelResolver.ResolvePageModel<Detail1PageModel>());
        }
    }

    public class MasterDetailChangeEventArgs : EventArgs
    {
        public int Position { get; set; }
    }
}