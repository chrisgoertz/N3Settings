/**
 * This file is part of the AppSettings library.
 * @date 2025-06-15
 * @author Christian Goertz <chris.goertz@gmx.de>
 * GNU General Public Licence v3.0
 * ***********************************40***************************************80*/
namespace ncdf.de;

public interface IAppSettings
{
    int WindowHeight { get; set; }
    int WindowWidth { get; set; }
    string OpcServerIp { get; set; }
    string DatabaseIp { get; set; }
}

/**
 * Changelog:
 * 2025-06-15
 * - file created.
 *
 */
