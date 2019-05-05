using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using FreshMvvm;
using System;

namespace Popup
{
    public class MainPageModel : FreshBasePageModel
    {

        #region Default Override functions
        public override void Init(object initData)
        {
            base.Init(initData);
            MainPageLabel = "Fresh Mvvm Tutorial!";
        }
        #endregion

        #region Commands
        public Command GotoSecondPageCommand
        {
            get
            {
                return new Command(async () =>
                {
                    await CoreMethods.PushPopupPageModel<MyPopupPageModel>();
                });
            }
        }
        #endregion

        #region Properties
        string _mainPageLabel = string.Empty;
        public string MainPageLabel
        {
            get
            {
                return _mainPageLabel;
            }
            set
            {
                if (_mainPageLabel != value)
                {
                    _mainPageLabel = value;
                    RaisePropertyChanged(nameof(MainPageLabel));
                }
            }
        }
        #endregion

    }
}
