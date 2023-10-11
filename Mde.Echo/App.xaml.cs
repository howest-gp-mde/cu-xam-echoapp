using FreshMvvm;
using Mde.Echo.Pages;
using Mde.Echo.ViewModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mde.Echo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = FreshPageModelResolver.ResolvePageModel<MainViewModel>();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
