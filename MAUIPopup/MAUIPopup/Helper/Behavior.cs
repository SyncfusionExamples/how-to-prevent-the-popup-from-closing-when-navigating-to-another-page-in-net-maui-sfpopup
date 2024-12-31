using Syncfusion.Maui.Popup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIPopup
{
    public class Behavior : Behavior<ContentPage>
    {
        #region Fields

        private Button button;
        private SfPopup popup;
        private bool canCloseopup;

        #endregion

        #region Override Methods

        protected override void OnAttachedTo(ContentPage bindable)
        {
            base.OnAttachedTo(bindable);
            button = bindable.FindByName<Button>("button");
            popup = bindable.FindByName<SfPopup>("popup");
            button.Clicked += OnNavigationPageButtonClicked;
            popup.Closing += OnPopupClosing;
        }

        

        protected override void OnDetachingFrom(ContentPage bindable)
        {
            base.OnDetachingFrom(bindable);
        }

        #endregion

        #region Private Methods

        private async void OnNavigationPageButtonClicked(object? sender, EventArgs e)
        {
            canCloseopup = false;
            popup.IsOpen = true;
            await Task.Delay(1000);
            await Application.Current.MainPage.Navigation.PushAsync(new NavigationPage1());
            await Task.Delay(1000);
            canCloseopup = true;
            popup.IsOpen = false;

        }

        private void OnPopupClosing(object? sender, System.ComponentModel.CancelEventArgs e)
        {
           if (!canCloseopup)
           {
                e.Cancel = true;
           }
        }

        #endregion
    }
}
