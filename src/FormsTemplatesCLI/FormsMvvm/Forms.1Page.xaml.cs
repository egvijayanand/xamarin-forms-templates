using Xamarin.Forms;
using Xamarin.Forms.Xaml;

#if (!SameFolder)
using MyApp.Namespace.ViewModels;

#endif
#if SameFolder
namespace MyApp.Namespace
#else
namespace MyApp.Namespace.Views
#endif
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Forms__1Page : ContentPage
    {
        public Forms__1Page()
        {
            InitializeComponent();
            BindingContext = new Forms__1ViewModel();
        }
    }
}
