﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Rassavada
{ // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NavigationPage : ContentPage
    {
        public NavigationPage(Page1 page1)
        {
            InitializeComponent();
        }




        private async void Login(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Page1());
        }
    }
}
