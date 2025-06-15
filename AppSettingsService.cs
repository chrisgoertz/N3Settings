/**
 * This file is part of the AppSettings library.
 * @date 2025-06-15
 * @author Christian Goertz <chris.goertz@gmx.de>
 * GNU General Public Licence v3.0
 * ***********************************40***************************************80*/
using Config.Net;

namespace ncdf.de;

public static class AppSettingsService
{

    public static IAppSettings AppSettings
    { get; } =
        new ConfigurationBuilder<IAppSettings>()
          .UseJsonFile("AppSettings.json")
          .Build();

    public static IOpcSettings OpcSettings { get; } =
      new ConfigurationBuilder<IOpcSettings>()
        .UseJsonFile("OpcSettings")
        .Build();
}

/**
 * Changelog:
 * 2025-06-15
 * - file created
 */
