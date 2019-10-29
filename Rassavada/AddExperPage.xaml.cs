using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Rassavada
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddExperPage : ContentPage
    {
        public AddExperPage()
        {
            InitializeComponent();
        }




        private async void Next(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ExperiencePage());
        }

        private void Seasonalchoose(object sender, EventArgs e)
        {

            if (Season.IsVisible == true)
            {
                Season.IsVisible = false;
                Downarrow.RotateTo(0);
            }
            else
            {
                Season.IsVisible = true;
                Downarrow.RotateTo(180);
                
            }

        }
        private void Seasonaltype(object sender, EventArgs e)
        {
            Option.Text = "Seasonal";
            Option.TextColor = Color.FromHex("#000000");
        }

        private void Nonseasonal(object sender, EventArgs e)
        {
            Option.Text = "Non-Seasonal";
            Option.TextColor = Color.FromHex("#000000");
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {

        }

        private void Quest(object sender, EventArgs e)
        {
            if (Question.IsVisible == true)
            {
                Question.IsVisible = false;
              
            }
            else
            {
                Question.IsVisible = true;
               

            }
        }

        private void Reviewquest(object sender, EventArgs e)
        {
            if (Questions.IsVisible == true)
            {
                Questions.IsVisible = false;

            }
            else
            {
                Questions.IsVisible = true;


            }
        }
    }
}
