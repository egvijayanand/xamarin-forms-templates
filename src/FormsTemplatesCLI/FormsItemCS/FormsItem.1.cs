using Xamarin.Forms;

namespace MyApp.Namespace
{
#if IsGeneric
    public partial class FormsItem__1 : ContentPage<TObject>
#else
    public partial class FormsItem__1 : ContentPage
#endif
    {
        public FormsItem__1()
        {
            
        }
    }
}
