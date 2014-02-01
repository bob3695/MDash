using MDash.Data.Models;
using System.Collections.Generic;

namespace MDash.Data.Contracts
{
    public interface IPlexServerRepository
    {
        PlexServer Get(int id);

        PlexServer Get(string ip);

        IEnumerable<PlexServer> GetAll();
    }
}