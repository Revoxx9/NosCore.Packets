﻿using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Inventory
{
    [PacketHeader("get")]
    public class ServerGetPacket : PacketBase
    {
        [PacketIndex(0)]
        public VisualType VisualType { get; set; }

        [PacketIndex(1)]
        public long VisualId { get; set; }

        [PacketIndex(2)]
        public long ItemId { get; set; }

        [PacketIndex(3)]
        public long Unknow { get; set; }
    }
}