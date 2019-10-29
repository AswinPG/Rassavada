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
    public partial class Packagename : Rg.Plugins.Popup.Pages.PopupPage
    {
        public Packagename()
        {
            InitializeComponent();
        }

        private async void Done(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PackagePage());
        }

       
    }
}