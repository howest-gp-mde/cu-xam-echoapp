using Mde.Echo.Services;
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
        protected readonly EchoService _echoService;

        public MainPage()
        {
            InitializeComponent();

            _echoService = new EchoService();
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

        private void BtnEcho_Clicked(object sender, EventArgs e)
        {
            lblOutput.Text = _echoService.ReverseIt(txtInput.Text);
        }
    }
}
