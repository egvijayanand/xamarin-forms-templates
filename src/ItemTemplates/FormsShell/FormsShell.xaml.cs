﻿using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $rootnamespace$
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class $safeitemname$ : Shell
    {
        public $safeitemname$()
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
