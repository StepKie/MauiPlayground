namespace MauiPlayground;

public static class ServiceHelper
{
    public static TService GetService<TService>() => Current.GetService<TService>();

    public static IServiceProvider Current =>
#if WINDOWS
        MauiWinUIApplication.Current.Services;
#elif ANDROID
         IPlatformApplication.Current.Services;
#elif IOS || MACCATALYST
         IPlatformApplication.Current.Services;
#else
        null;
#endif
}
