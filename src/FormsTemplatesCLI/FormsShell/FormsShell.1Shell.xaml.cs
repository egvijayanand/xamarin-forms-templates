﻿using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyApp.Namespace
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FormsShell__1Shell : Shell
    {
        public FormsShell__1Shell()
        {
            InitializeComponent();
        }

        // UnComment the below method to handle Shell Menu item click event
        // And ensure appropriate page definitions are available for it work as expected
        //private async void OnMenuItemClicked(object sender, EventArgs e)
        //{
        //    await Current.GoToAsync("//login");
        //}
    }
}
