using Microsoft.Extensions.Logging;

//using CommunityToolkit.Maui;                          // This line should not be necessary
using CommunityCameraReproToolkit;

namespace CommunityCameraReproWithBug
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                //.UseMauiCommunityToolkit()            // This line should not be necessary
                //.UseMauiCommunityToolkitCamera()      // This line should not be necessary
                .UseCommunityCameraReproToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
