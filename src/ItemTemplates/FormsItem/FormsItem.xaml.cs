using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
$if$ ($toolkit$ == true)

using Xamarin.CommunityToolkit.UI.Views;
$endif$

namespace $rootnamespace$
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class $safeitemname$ : $csbasetype$
    {
        public $safeitemname$()
        {
            InitializeComponent();
        }
    }
}
