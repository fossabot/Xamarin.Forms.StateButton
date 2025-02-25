﻿using System;
using Xamarin.Forms;

namespace App
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void StateButton_OnClicked(object sender, EventArgs e)
        {
            await DisplayAlert ("Clicked event", "Button clicked", "OK");
        }

        private async void StateButton_OnPressed(object sender, EventArgs e)
        {
            await DisplayAlert ("Pressed event", "Button pressed", "OK");
        }

        private async void StateButton_OnReleased(object sender, EventArgs e)
        {
            await DisplayAlert ("Released event", "Button released", "OK");
        }
    }
}
