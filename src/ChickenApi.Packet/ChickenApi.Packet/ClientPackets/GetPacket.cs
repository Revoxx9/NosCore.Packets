﻿using ChickenApi.Packet.Enumerations;

namespace ChickenApi.Packet.ClientPackets
{
    [PacketHeader("get")]
    public class GetPacket : IPacket
    {
        [PacketIndex(0)]
        public VisualType PickerType { get; set; }

        [PacketIndex(1)]
        public long PickerId { get; set; }

        [PacketIndex(2)]
        public long VisualId { get; set; }
    }
}