using Xamarin.Forms;

namespace MyApp.Namespace
{
    public partial class FormsView__1View : ContentView
    {
        public FormsView__1View()
        {
            Content = new StackLayout()
            {
                Children =
                {
                    new Label()
                    {
                        Text = "Hello from Xamarin.Forms!!!",
                        TextColor = Color.Purple,
                        HorizontalOptions = LayoutOptions.CenterAndExpand,
                        VerticalOptions = LayoutOptions.CenterAndExpand
                    }
                }
            };
        }
    }
}
