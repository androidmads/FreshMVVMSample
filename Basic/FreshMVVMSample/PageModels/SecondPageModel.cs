using FreshMvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FreshMVVMSample
{
    public class SecondPageModel : FreshBasePageModel
    {
        public override void Init(object initData)
        {
            base.Init(initData);
        }

        public override void ReverseInit(object returnedData)
        {
            base.ReverseInit(returnedData);
        }

        protected override void ViewIsAppearing(object sender, EventArgs e)
        {
            base.ViewIsAppearing(sender, e);
        }

        protected override void ViewIsDisappearing(object sender, EventArgs e)
        {
            base.ViewIsDisappearing(sender, e);
        }

        #region Commands
        public Command GoBackCommand
        {
            get
            {
                return new Command(async () =>
                {
                    await CoreMethods.PopPageModel();
                    //await CoreMethods.PopToRoot(animate:false);
                });
            }
        }
        #endregion
    }
}
