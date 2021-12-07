using Foundation;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace Winstanley.BlazorMauiHybrid.Native
{
    [Register("AppDelegate")]
    public class AppDelegate : MauiUIApplicationDelegate
    {
        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
    }
}