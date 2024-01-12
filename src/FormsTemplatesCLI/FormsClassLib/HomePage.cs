using Xamarin.Forms;
using Xamarin.Forms.Xaml;
#if (AddEssentials || AddEssentialsInterfaces)

using Xamarin.Essentials;
#endif
#if AddEssentialsInterfaces
using Xamarin.Essentials.Implementation;
using Xamarin.Essentials.Interfaces;
#endif
#if AddToolkit

using Xamarin.CommunityToolkit.Behaviors;
using Xamarin.CommunityToolkit.Converters;
using Xamarin.CommunityToolkit.Effects;
using Xamarin.CommunityToolkit.ObjectModel;
using Xamarin.CommunityToolkit.UI.Views;
#endif
#if AddMarkup

using Xamarin.CommunityToolkit.Markup;
#endif
#if AddMvvmToolkit

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
#endif
#if AddSharedToolkit

using VijayAnand.Toolkit.Markup;
#endif
#if AddSharedToolkit

// Static
using static Xamarin.CommunityToolkit.Markup.GridRowsColumns;
using static VijayAnand.Toolkit.Markup.ResourceHelper;
using static VijayAnand.Toolkit.Markup.VisualStateHelper;
#elif AddMarkup

// Static
using static Xamarin.CommunityToolkit.Markup.GridRowsColumns;
#endif

namespace FormsClassLib._1
{
    public class HomePage : ContentPage
    {
        public HomePage()
        {
            
        }
    }
}
