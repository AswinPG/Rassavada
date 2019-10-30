using Rg.Plugins.Popup.Services;
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

       
        private async void Create(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PushAsync(new SelectTypeof());
        }
    }
}