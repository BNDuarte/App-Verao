using DLToolkit.Forms.Controls;
using System;
using Verao.Views.Principal;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Verao
{
    public partial class App : Application
    {
        public App()
        {
            LiveReload.Init();
            InitializeComponent();
            FlowListView.Init();
            MainPage = new HomeView();
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
