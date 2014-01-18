﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDash.Plex.Contracts
{
    public class MediaContainer
    {
        public List<Video> Videos { get; set; }
    }

    public class Video
    {
        public Player Player { get; set; }
    }

    public class Player
    {
        public string MachineIdentifier { get; set; }
    }
}
