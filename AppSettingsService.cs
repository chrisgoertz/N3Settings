using Config.Net;

namespace ncdf.de;

public static class AppSettingsService
{

    public static IAppSettings AppSettings
    { get; }
    =
      new ConfigurationBuilder<IAppSettings>()
      .UseJsonFile("AppSettings.json")
      .Build();

}
