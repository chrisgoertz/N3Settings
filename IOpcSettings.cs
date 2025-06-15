/**
 * This file is part of the AppSettings library.
 * @date 2025-06-15
 * @author Christian Goertz <chris.goertz@gmx.de>
 * GNU General Public Licence v3.0
 * ***********************************40***************************************80*/
namespace ncdf.de;

public interface IOpcSettings
{
    string OpcServerEndPoint { get; }
    int OpcRefreshInterval { get; }
    int OpcTimeout { get; }

    /* DB100 Link */
    string Db100_Namespace { get; }
    string Db100_PcSequenceId1 { get; }
    string Db100_PcSequenceId2 { get; }
    string Db100_OrderId { get; }
    string Db100_OrderText { get; }

    /* DB101 Link */
    string Db101_Namespace { get; }
    string Db101_PlcSequenceId1 { get; }
    string Db101_PlcSequenceId2 { get; }
    string Db101_OrderId { get; }
    string Db101_Status { get; }

    /* Db102 Link */
    string Db102_Namespace { get; }
    string Db102_PlcSequenceId1 { get; }
    string Db102_PlcSequenceId2 { get; }
    string Db102_OrderId { get; }
    string Db102_Status { get; }
}
/**
 * Changelog:
 * 2025-06-15
 * - file created
 */
