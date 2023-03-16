using Xamarin.Forms;

namespace MyApp.Namespace
{
    public partial class FormsView__1 : ContentView
    {
        public FormsView__1()
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
