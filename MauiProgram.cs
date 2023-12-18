using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using Sharpnado.Tabs;

namespace casamento_conectado
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("FeelingLovely.ttf", "FeelingLovely");
                    fonts.AddFont("FASolid-900.otf", "FASolid");
                })
                .UseSharpnadoTabs(loggerEnable: false)
                  .UseMauiCommunityToolkit();

            return builder.Build();
        }
    }
}
