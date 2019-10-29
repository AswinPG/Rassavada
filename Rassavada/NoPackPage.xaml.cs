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
    public partial class NoPackPage : ContentPage
    {
        public NoPackPage()
        {
            InitializeComponent();
        }

        private async void Create(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddPackagePage());
        }
    }
}