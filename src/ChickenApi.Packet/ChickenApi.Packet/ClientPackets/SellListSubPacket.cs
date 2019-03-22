﻿namespace ChickenApi.Packet.ClientPackets
{
    [PacketHeader("sell_list_subpacket")]
    public class SellListSubPacket : IPacket
    {
        [PacketIndex(0)]
        public short Slot { get; set; }

        [PacketIndex(1)]
        public long Amount { get; set; }

        [PacketIndex(2)]
        public long SellAmount { get; set; }
    }
}