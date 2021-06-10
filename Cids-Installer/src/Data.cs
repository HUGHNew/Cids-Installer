using System.Text.Json.Serialization;

namespace Cids_Installer
{
    public class DBInfo
    {
        public string Ip { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public string Database { get; set; }
        public uint Port { get; set; }
    }
    namespace ConfComponent
    {
        public class NetData
        {
            public string Main_Ip { get; set; }
            public int Main_Port { get; set; }
            public int Mirror_Port { get; set; }
            [JsonIgnore]
            public bool IPv4 => Main_Ip.Contains("."); // need to be transient
        }
        public class TimeData
        {
            // interval of each Udp package
            public int Delay { get; set; }
            // heartbeat interval
            public int HeartBeat { get; set; }
            // the max times of no response heartbeat
            public int Limit { get; set; }
            public SleepTime Sleep { get; set; }
        }
        public class SleepTime
        {
            public int Min { get; set; }
            public int Max { get; set; }
        }
    }
    public class Conf
    {
        public ConfComponent.NetData Net { get; set; }
        public ConfComponent.TimeData Time { get; set; }
        // Udp =1
        // Tcp =2
        // Quic=3
        public int Protocol { get; set; }
        public string Logo { get; set; }
    }
}
