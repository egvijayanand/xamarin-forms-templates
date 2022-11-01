﻿using Xamarin.Forms;

namespace MyApp.Namespace
{
    public partial class FormsView : ContentView
    {
        public FormsView()
        {
            Content = new StackLayout()
            {
                Children =
                {
                    new Label()
                    {
                        Text = "Hello from Xamarin.Forms!!!",
                        HorizontalOptions = LayoutOptions.CenterAndExpand,
                        VerticalOptions = LayoutOptions.CenterAndExpand
                    }
                }
            };
        }
    }
}