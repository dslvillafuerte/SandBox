using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SandBox.Views;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace SandBox
{
   
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            this.MainPage = new NavigationPage(new MyFirstPage());
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
