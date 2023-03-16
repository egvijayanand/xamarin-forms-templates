using Xamarin.Forms;

namespace MyApp.Namespace
{
    public partial class FormsPage__1 : ContentPage
    {
        public FormsPage__1()
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
