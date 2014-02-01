using AutoMapper;
using MDash.Models;
using MDash.Plex.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MDash
{
    public class MapperConfig
    {
        
        /// <summary>
        /// Sets all the injectors for the web project up!
        /// </summary>
        public static void RegisterMapper()
        {
            Mapper.CreateMap<ClientInfo, NowPlayingClients>();
            Mapper.CreateMap<Server, NowPlayingClient>();
        }
    }
}