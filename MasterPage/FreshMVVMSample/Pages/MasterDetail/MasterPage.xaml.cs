using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FreshMVVMSample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterPage : ContentPage
    {
        public MasterPage()
        {
            InitializeComponent();
        }

        private void DetailButton1Clicked(object sender, EventArgs e)
        {

        }

        private void DetailButton2Clicked(object sender, EventArgs e)
        {


        }
    }
}