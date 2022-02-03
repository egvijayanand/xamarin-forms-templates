### CLI Project and Item Templates for developing Xamarin.Forms App that runs on iOS, Android, and Windows

Project template for Xamarin.Forms Class Library and is named as `formsclasslib`

Item templates for ContentPage, ContentView, and ShellPage in XAML and named as `forms-page`, `forms-view`, and `forms-shell` respectively.

Project template currently target Xamarin.Forms 5.0 Service Release 9 (ver. 5.0.0.2337).

To install the template NuGet package, use the below .NET CLI command:

```shell
dotnet new --install VijayAnand.FormsTemplates
```

If you've already installed this package, then it can be updated to the latest version with the below command:

```shell
dotnet new --update-check
dotnet new --update-apply
```
Use the below .NET CLI command to create the project, pages, and views out these templates:

```shell
dotnet new formsclasslib -n MyApp.Core
```
```shell
dotnet new forms-page -n LoginPage -na MyApp.Views
```
```shell
dotnet new forms-view -n CardView -na MyApp.Views
```
```shell
dotnet new forms-shell -n AppShell -na MyApp
```
Here `-n` denotes the name of the project/page/view that is to be created (for pages/views, don't need to suffix it with .xaml, it will be added automatically) (Can also be specified as `--name`). 

*Note: If name parameter is not provided, the .NET CLI template engine will take the current folder name in the context as its name.*

And `-na` denotes the namespace under which the file is to be created (Can also be specified as `--namespace`).
