using Microsoft.Extensions.Logging;
using BlazorHybridShareStateDemo.Data;

namespace BlazorHybridShareStateDemo;

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
			});

		builder.Services.AddMauiBlazorWebView();

#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
		builder.Logging.AddDebug();
#endif

		builder.Services.AddSingleton<WeatherForecastService>();

		// Make a single instance of this type available to the app
		builder.Services.AddSingleton<MySharedState>();

		return builder.Build();
	}
}
