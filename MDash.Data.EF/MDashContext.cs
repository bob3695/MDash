using MDash.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDash.Data.EF
{
    public class MDashContext : DbContext
    {
        public DbSet<PlexServer> PlexServers { get; set; }
    }
}
