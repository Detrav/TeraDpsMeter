﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Detrav.Sniffer.Tera.P2805
{
    class S_DESPAWN_USER : TeraPacketParser
    {
        public S_DESPAWN_USER(TeraPacket packet) :base (packet)
        {
            readUInt64(4, "id");
        }
    }
}
