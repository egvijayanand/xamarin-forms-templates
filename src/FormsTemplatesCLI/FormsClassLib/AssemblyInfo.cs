using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
#if NoPolySharp

// For making use of C# 9.0 features such as Records.

namespace System.Runtime.CompilerServices
{
    internal class IsExternalInit { }
}
#endif
