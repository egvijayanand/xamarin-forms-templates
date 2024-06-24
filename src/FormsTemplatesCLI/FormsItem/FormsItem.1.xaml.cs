using Xamarin.Forms;
using Xamarin.Forms.Xaml;
#if Toolkit

using Xamarin.CommunityToolkit.UI.Views;
#endif

namespace MyApp.Namespace
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
#if IsGeneric
    public partial class FormsItem__1 : ContentView<TContext>
#else
    public partial class FormsItem__1 : ContentView
#endif
    {
        public FormsItem__1()
        {
            InitializeComponent();
        }
    }
}
