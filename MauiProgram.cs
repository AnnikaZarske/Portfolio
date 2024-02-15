using Microsoft.Extensions.Logging;
using MudBlazor.Services;

namespace Portfolio
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
                    fonts.AddFont("Estedad-Regular.ttf", "EstedadRegular");
                });

            builder.Services.AddMauiBlazorWebView();
            //builder.Services.AddMudPopoverService();
            builder.Services.AddMudServices();


#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
