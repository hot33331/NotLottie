using System;
using Xamarin.Forms;
using NotLottie.Views;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace NotLottie
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            var page = new MyPage();

            MainPage = page;
            page._show += OnShow;
        }

        private void OnShow(object sender, EventArgs e)
        {
            MainPage = new MainPage();
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
