using Mde.Echo.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Mde.Echo.Pages
{
    public partial class MainPage : ContentPage
    {
        private const int translationDelta = 600;
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            btnEcho.TranslationX = translationDelta;

            btnEcho.TranslateTo(
                btnEcho.X, btnEcho.Y,
                750,
                Easing.SpringOut
            );
        }

    }
}
