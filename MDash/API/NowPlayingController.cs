using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MDash.Plex;
using MDash.Plex.Models;
using AutoMapper;
using MDash.Models;

namespace MDash.API
{
    public class NowPlayingController : ApiController
    {
        public NowPlayingClients Get()
        {
            PlexAPI api = new PlexAPI("192.168.30.202", "32400");

            // TODO: Map this to a view model
            var clients = api.GetClients(true);

            NowPlayingClients npClients = Mapper.Map<NowPlayingClients>(clients);

            return npClients;
        }
    }
}
