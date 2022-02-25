using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyApp.Namespace
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FormsResDict : ResourceDictionary
    {
        public FormsResDict()
        {
            InitializeComponent();
        }
    }
}
