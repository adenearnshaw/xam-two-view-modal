﻿using System;
using System.Collections.Generic;
using XF.ModalNavigation.Views;
using Xamarin.Forms;

namespace XF.ModalNavigation.Views
{
    public partial class ModalPageOne : ContentPage
    {
        public ModalPageOne()
        {
            InitializeComponent();
        }

        public async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
           await Navigation.PushAsync(new ModalPageTwo());
        }

        public async void Close_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PopModalAsync(true);
        }
    }
}
