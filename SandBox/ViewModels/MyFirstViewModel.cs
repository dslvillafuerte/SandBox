using System;
namespace SandBox.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using System.Windows.Input;
    //using Services;
    using Views;
    using Xamarin.Forms;
    //using Helpers;
    public class MyFirstViewModel : BaseViewModel
    {

        #region Attributes
        private string email;

        #endregion

        #region Properties
        public string Email
        {
            get { return this.email; }
            set { SetValue(ref this.email, value); }
        }
        #endregion

        public MyFirstViewModel()
        {
        }

        #region Commands
        public ICommand LoginCommand
        {
            get
            {
                return new RelayCommand(Login);
            }
        }
        #endregion

        private async void Login()
        {
            await Application.Current.MainPage.DisplayAlert(
                    "Hola",
                    "Mundo",
                    "Aceptar");
            return;
        }
    }
}
