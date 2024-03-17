using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using Microsoft.Maui.Controls;
using Microsoft.Maui.LifecycleEvents;
using System.Runtime.Intrinsics.X86;
using System.Threading.Channels;
using Xe.AcrylicView;

namespace Papaya
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
            .UseMauiApp<App>()
            .UseMauiCommunityToolkit()
                .UseAcrylicView()
                .ConfigureLifecycleEvents(events =>
                 {
#if ANDROID
              
                events.AddAndroid(android => android.OnCreate((activity, bundle) => MakeStatusBarTranslucent(activity)));
      
                static void MakeStatusBarTranslucent(Android.App.Activity activity)
                {
             
                activity.Window.SetNavigationBarColor(Android.Graphics.Color.ParseColor("#FCBC03"));

                }
#endif
                 })
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("Roboto-Regular.ttf", "Regular");
                    fonts.AddFont("Roboto-Bold.ttf", "Bold");

                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

//#if DEBUG
//    		builder.Logging.AddDebug();
//#endif

            return builder.Build();
        }


    }
}
