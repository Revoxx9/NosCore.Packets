﻿namespace ChickenApi.Packet.ServerPackets
{
    [PacketHeader("delay")]
    public class DelayPacket : IPacket
    {
        [PacketIndex(0)]
        public short Delay { get; set; }

        [PacketIndex(1)]
        public byte Type { get; set; }

        [PacketIndex(2, IsReturnPacket = true)]
        public IPacket Packet { get; set; }
    }
}