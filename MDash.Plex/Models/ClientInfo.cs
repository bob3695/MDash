using System.Collections.Generic;

namespace MDash.Plex.Models
{
    public class ClientInfo
    {
        public List<Server> Clients { get; set; }
    }

    public class Server
    {
        public string Name { get; set; }

        public string Host { get; set; }

        public string Address { get; set; }

        public string Port { get; set; }

        public string MachineIdentifier { get; set; }

        public string Version { get; set; }

        public string Protocol { get; set; }

        public string Product { get; set; }

        public string DeviceClass { get; set; }

        public string ProtocolVersion { get; set; }

        public PlexVideo NowPlaying { get; set; }
    }
}
