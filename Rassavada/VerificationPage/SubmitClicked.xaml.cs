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
    public partial class SubmitClicked : ContentPage
    {
        public SubmitClicked()
        {
            InitializeComponent();
        }
        private async void Backto(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Page1());
        }


    }
}