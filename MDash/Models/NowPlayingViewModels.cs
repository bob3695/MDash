using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MDash.Models
{
    public class NowPlayingClients
    {
        public List<NowPlayingClient> Clients { get; set; }
    }

    public class NowPlayingClient
    {
        public string Address { get; set; }
        public string Name { get; set; }
    }
}