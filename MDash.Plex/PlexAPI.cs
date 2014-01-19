using MDash.Plex.Models;
using RestSharp;
using System.Collections.Generic;

namespace MDash.Plex
{
    public class PlexAPI
    {
        public NowPlayingInfo GetNowPlaying(string ip, string port)
        {
            // TODO: Re-arch to make it work correctly
            var client = new RestClient();
            var request = new RestRequest(string.Format("http://{0}:{1}/status/sessions", ip, port));

            var response = client.Execute<NowPlayingInfo>(request);



            return null;
        }
    }
}