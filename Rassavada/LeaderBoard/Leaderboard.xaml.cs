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
    public partial class leaderboard : ContentPage
    {
        public leaderboard()
        {
            InitializeComponent();

            List<leader> Places = new List<leader>
            {
                new leader
                {
                    Number = "1",
                    Picture = "example.png",
                    Name = "Stan Marton",
                    Points = "8789",
                },
                new leader
                {
                    Number = "2",
                    Picture = "example.png",
                    Name = "Stan Marton",
                    Points = "8789",
                },
                new leader
                {
                    Number = "2",
                    Picture = "example.png",
                    Name = "Stan Marton",
                    Points = "8789",
                },
                new leader
                {
                    Number = "2",
                    Picture = "example.png",
                    Name = "Stan Marton",
                    Points = "8789",
                },
                new leader
                {
                    Number = "1",
                    Picture = "example.png",
                    Name = "Stan Marton",
                    Points = "8789",
                },
                new leader
                {
                    Number = "2",
                    Picture = "example.png",
                    Name = "Stan Marton",
                    Points = "8789",
                },
                new leader
                {
                    Number = "2",
                    Picture = "example.png",
                    Name = "Stan Marton",
                    Points = "8789",
                },
                new leader
                {
                    Number = "2",
                    Picture = "example.png",
                    Name = "Stan Marton",
                    Points = "8789",
                },
                new leader
                {
                    Number = "1",
                    Picture = "example.png",
                    Name = "Stan Marton",
                    Points = "8789",
                },


            };
            boardname.ItemsSource = Places;

        }
    }
}