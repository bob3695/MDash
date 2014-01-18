using MDash.Plex.Contracts;
using RestSharp;
using System.Collections.Generic;

namespace MDash.Plex
{
    public class PlexAPI
    {
        public IList<MediaContainer> GetNowPlaying(string ip, string port)
        {
            // TODO: Re-arch to make it work correctly
            var client = new RestClient();
            var request = new RestRequest(string.Format("http://{0}:{1}/status/sessions", ip, port));

            var response = client.Execute<MediaContainer>(request);



            return null;
        }
    }
}