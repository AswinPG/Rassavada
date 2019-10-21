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
    public partial class NoExperPage : ContentPage
    {
        public NoExperPage()
        {
            InitializeComponent();
        }

        private async void createexperience(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ExperiencePage());
        }
    }
}