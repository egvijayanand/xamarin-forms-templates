using Microsoft.VisualStudio.Shell;
using System.Reflection;
using System.Runtime.InteropServices;
using VijayAnand.XFormsTemplates;

// For Visual Studio to locate and load the component assembly during runtime
[assembly: ProvideCodeBase(AssemblyName = "VijayAnand.XFormsTemplates")]

[assembly: AssemblyTitle(Vsix.Name)]
[assembly: AssemblyDescription(Vsix.Description)]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany(Vsix.Author)]
[assembly: AssemblyProduct(Vsix.Name)]
[assembly: AssemblyCopyright(Vsix.Author)]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

[assembly: ComVisible(false)]

[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]
[assembly: AssemblyInformationalVersion("1.0.0.0")]

namespace System.Runtime.CompilerServices
{
    public class IsExternalInit { }
}
