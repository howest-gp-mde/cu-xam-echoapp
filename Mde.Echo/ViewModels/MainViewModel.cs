using FreshMvvm;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mde.Echo.ViewModels
{
    public class MainViewModel : FreshBasePageModel
    {
        private string[] words = new[]
        {
            "Bazinga!",
            "Bamboozelt",
            "Pizaaaaah",
            "Kieken",
        };
        private Random random = new Random();

        public MainViewModel()
        {
            Input = "";
        }

        protected override void ViewIsAppearing(object sender, EventArgs e)
        {
            _ = GetNextWord();
        }

        private async Task GetNextWord()
        {
            while(true)
            {
                string word = words[random.Next(words.Length)];
                Input = word;
                await Task.Delay(1000);
            }
        }

        private string input;
        public string Input
        {
            get { return input; }
            set { 
                input = value;
                RaisePropertyChanged();
            }
        }

        private string output;

        public string Output
        {
            get { return output; }
            set { 
                output = value;
                RaisePropertyChanged();
            }
        }


    }
}
