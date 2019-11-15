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
    public partial class PointsClicked : ContentPage
    {
        public PointsClicked()
        {
            InitializeComponent();
            List<Greek> Places = new List<Greek>
            {
                new Greek
                {

                    image = "Vector1.svg",
                    Name = "Packages Created" ,
                    Points = "10",
                },
                new Greek
                {

                    image = "Vector2.svg",
                    Name = "Places Added" ,
                    Points = "10",
                },
                new Greek
                {

                    image = "Vector3.svg",
                    Name = "Photos added" ,
                    Points = "10",
                }
            };
            collview.ItemsSource = Places;
        }
    }
}