using FreshMvvm;
using Xamarin.Forms;

namespace Popup
{
    public class MyPopupPageModel : FreshBasePageModel
    {

        public Command ClosePopupCommand
        {
            get
            {
                return new Command(() =>
                {
                    CoreMethods.PopPopupPageModel();
                });
            }
        }

    }
}
