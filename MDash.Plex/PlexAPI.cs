using MDash.Plex.Models;
using RestSharp;
using System.Collections.Generic;
using System.Linq;

namespace MDash.Plex
{
    public class PlexAPI
    {
        private string ip;
        private string port;

        public PlexAPI(string ip, string port)
        {
            this.ip = ip;
            this.port = port;
        }

        public ClientInfo GetClients(bool nowPlaying)
        {
            var clients = GetClients();

            if (nowPlaying)
            {
                var playingInfo = GetNowPlaying();

                foreach (var client in clients.Clients)
                {
                    if (playingInfo.Videos.Any(v => v.Player.MachineIdentifier == client.MachineIdentifier))
                    {
                        client.NowPlaying = playingInfo.Videos.First(v => v.Player.MachineIdentifier == client.MachineIdentifier);
                    }
                }
            }

            return clients;
        }

        public ClientInfo GetClients()
        {
            var client = GetRestClient();
            var request = GetRestRequest("clients");
            var response = client.Execute<ClientInfo>(request);

            return response.Data;
        }

        public NowPlayingInfo GetNowPlaying()
        {
            var client = GetRestClient();
            var request = GetRestRequest("status/sessions");          
            var response = client.Execute<NowPlayingInfo>(request);
            
            return response.Data;
        }

        private RestClient GetRestClient()
        {
            var client = new RestClient();
            client.ClearHandlers();
            client.AddHandler("application/xml", new PlexXmlDeserializer());
            client.AddHandler("text/xml", new PlexXmlDeserializer());

            return client;
        }

        private RestRequest GetRestRequest(string path)
        {
            return new RestRequest(string.Format("http://{0}:{1}/{2}", ip, port, path));
        }
    }
}