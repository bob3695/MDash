using MDash.Data.Contracts;
using MDash.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MDash.Data.EF
{
    public class PlexServerRespository : IPlexServerRepository, IDisposable
    {
        #region Private Variables

        private MDashContext context;

        #endregion Private Variables

        #region Constructor

        public PlexServerRespository(MDashContext context)
        {
            this.context = context;
        }

        #endregion Constructor

        #region Get Methods

        public PlexServer Get(int id)
        {
            return this.context.PlexServers.Find(id);
        }

        public PlexServer Get(string ip)
        {
            return this.context.PlexServers.FirstOrDefault(ps => ps.Ip == ip);
        }

        #endregion Get Methods

        #region Get All Methods

        public IList<PlexServer> GetAll()
        {
            return this.context.PlexServers.ToList();
        }

        #endregion Get All Methods

        public void Dispose()
        {
            
        }
    }
}