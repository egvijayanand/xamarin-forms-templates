/*
global using Xamarin.Forms;
global using Xamarin.Forms.Xaml;
#if AddMaps

global using Xamarin.Forms.Maps;
#endif
#if (AddEssentials || AddEssentialsInterfaces)

global using Xamarin.Essentials;
#endif
#if AddEssentialsInterfaces
global using Xamarin.Essentials.Implementation;
global using Xamarin.Essentials.Interfaces;
#endif
#if AddToolkit

global using Xamarin.CommunityToolkit.Behaviors;
global using Xamarin.CommunityToolkit.Converters;
global using Xamarin.CommunityToolkit.Effects;
global using Xamarin.CommunityToolkit.ObjectModel;
global using Xamarin.CommunityToolkit.UI.Views;
#endif
#if (AddMarkup || AddSharedToolkit)

global using Xamarin.CommunityToolkit.Markup;
#endif
#if AddMvvmToolkit

global using CommunityToolkit.Mvvm.ComponentModel;
global using CommunityToolkit.Mvvm.Input;
global using CommunityToolkit.Mvvm.Messaging;
#endif
#if AddSharedToolkit

global using VijayAnand.Toolkit.Markup;
#endif
#if AddSharedToolkit

// Static
global using static Xamarin.CommunityToolkit.Markup.GridRowsColumns;
global using static VijayAnand.Toolkit.Markup.ResourceHelper;
global using static VijayAnand.Toolkit.Markup.VisualStateHelper;
#elif AddMarkup

// Static
global using static Xamarin.CommunityToolkit.Markup.GridRowsColumns;
#endif
*/
