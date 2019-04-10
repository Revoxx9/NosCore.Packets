﻿using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ClientPackets.Chat
{
    [PacketHeader("/")]
    public class WhisperPacket : IPacket
    {
        [PacketIndex(0)]
        public string Message { get; set; }
    }
}