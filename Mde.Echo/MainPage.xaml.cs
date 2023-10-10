using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Mde.Echo
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
            txtInput.TranslationX = translationDelta;
            btnEcho.TranslationX = txtInput.TranslationX;

            txtInput.TranslateTo(
                txtInput.X, txtInput.Y,
                750,
                Easing.BounceOut
            );

            btnEcho.TranslateTo(
                btnEcho.X, btnEcho.Y,
                750,
                Easing.SpringOut
            );
        }

    }
}
