﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using NosCore.Packets.Attributes;

namespace NosCore.Packets.ClientPackets.Exchanges
{
    [PacketHeader("exc_list")]
    public class ExcListPacket : PacketBase
    {
        [PacketIndex(0)]
        [Range(0, long.MaxValue)]
        public long Gold { get; set; }

        [PacketIndex(1)]
        [Range(0, long.MaxValue)]
        public long BankGold { get; set; }

        [PacketIndex(2, SpecialSeparator = " ")]
        public List<ExcListSubPacket?>? SubPackets { get; set; }
    }
}