### Xamarin.Forms Project and Item Templates for building native apps for iOS, Android, UWP, macOS, Tizen from a single, shared C# codebase.

Join me on [**Developer Thoughts**](https://egvijayanand.in/), an exclusive blog for Xamarin.Forms, .NET MAUI, and Blazor with articles on working with it.

#### Available to install from

|NuGet|VS Marketplace|
|:---:|:---:|
|[![VijayAnand.FormsTemplates - NuGet Package](https://badgen.net/nuget/v/VijayAnand.FormsTemplates/)](https://www.nuget.org/packages/VijayAnand.FormsTemplates/)|[![Xamarin.Forms Project and Item Templates - VS Marketplace](https://badgen.net/vs-marketplace/v/egvijayanand.xamarin-forms-templates)](https://marketplace.visualstudio.com/items?itemName=egvijayanand.xamarin-forms-templates)|

#### Access within Visual Studio IDE

Installation:

![Install from VS Marketplace](images/xamarin-forms-vs-extension.png)

Project Template Listing:

![Xamarin.Forms Class Library Project Template](images/xamarin-forms-class-library.png)

Project Options:

![Xamarin.Forms Class Library - Project Options](images/xamarin-forms-class-library-options.png)

Item Templates:

![Xamarin.Forms - Item Templates](images/xamarin-forms-item-templates.png)

#### Access via CLI

To install the template NuGet package, use the below .NET CLI command:

```shell
dotnet new install VijayAnand.FormsTemplates
```

If you've already installed this package, then it can be updated to the latest version with the below command:

```shell
dotnet new update --check-only
```
```shell
dotnet new update
```
Project template for Xamarin.Forms Class Library and is named as `formsclasslib`

And it currently targets Xamarin.Forms 5.0 Service Release 12 (ver. 5.0.0.2515).

Item templates for `ContentPage`, `ContentView`, `ShellPage`, and `ResourceDictionary` in XAML and named as `forms-page`, `forms-view`, `forms-shell`, and `forms-resdict` respectively. There's a C# item template for `ContentPage` and `ContentView` and named as `forms-page-cs` and `forms-view-cs` respectively.

Use the below .NET CLI command to create the project, pages, and views out these templates:

An optional parameter has been introduced to choose the library target framework (.NET Standard 2.0 / 2.1):

* `-f` | `--framework` - Default value is `netstandard2.0`

Library target framework override:
```shell
dotnet new formsclasslib -n MyApp.Core -f netstandard2.1
```

Class library project templates take the below optional parameters to include the officially supported `Xamarin.CommunityToolkit`, `Xamarin.CommunityToolkit.Markup`, `Xamarin.Essentials`, `CommunityToolkit.Mvvm` (aka Microsoft MVVM Toolkit) or all NuGet packages:

* `-it` | `--include-toolkit` - Default value is `false`
* `-im` | `--include-markup` - Default value is `false`
* `-ie` | `--include-essentials` - Default value is `false`
* `-imt` | `--include-mvvm-toolkit` - Default value is `false`

Note: `v2.0.x` is the NuGet package version being added out-of-the-box for Xamarin Toolkit packages, `v1.7.3` for Xamarin.Essentials package and `v8.0.0` for MVVM Toolkit package.

```shell
dotnet new formsclasslib -n MyApp.UI -it -im -ie -imt
```

Page:
```shell
dotnet new forms-page -n LoginPage -na MyApp.Views
```
```shell
dotnet new forms-page-cs -n HomePage -na MyApp.Views
```

View:
```shell
dotnet new forms-view -n CardView -na MyApp.Views
```
```shell
dotnet new forms-view-cs -n ContactsView -na MyApp.Views
```

Shell:
```shell
dotnet new forms-shell -n AppShell -na MyApp
```

Resource Dictionary:

With C# code-behind file:
```shell
dotnet new forms-resdict -n DarkTheme -na MyApp.Themes
```

Without C# code-behind file - Xaml Only (Option can be `-xo` or `--xaml-only`):
```shell
dotnet new forms-resdict -n DarkTheme -na MyApp.Themes -xo
```

Here `-n` denotes the name of the project/page/view that is to be created (for pages/views, don't need to suffix it with .xaml, it will be added automatically) (Can also be specified as `--name`). 

*Note: If name parameter is not provided, the .NET CLI template engine will take the current folder name in the context as its name.*

And `-na` denotes the namespace under which the file is to be created (Can also be specified as `--namespace`). _While working with .NET 7 SDK, the `namespace` parameter in short notation needs to be passed as `-p:na` (i.e., it needs to be prefixed with `-p:`)._
