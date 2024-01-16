using Xamarin.Forms;

#if (!SameFolder)
using MyApp.Namespace.ViewModels;

#endif
#if SameFolder
namespace MyApp.Namespace
#else
namespace MyApp.Namespace.Views
#endif
{
    public partial class Forms__1Page : ContentPage
    {
        public Forms__1Page()
        {
            BindingContext = new Forms__1ViewModel();
            Content = new Grid()
            {
                Children =
                {
                    new Label()
                    {
                        Text = "Welcome to Xamarin.Forms!!!",
                        TextColor = Color.Purple,
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.Center
                    }
                }
            };
        }
    }
}
