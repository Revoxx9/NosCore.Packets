﻿//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// 
// Copyright (C) 2019 - NosCore
// 
// NosCore is a free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System.Collections.Generic;
using NosCore.Packets.Attributes;
using NosCore.Packets.ServerPackets.Inventory;

namespace NosCore.Packets.ServerPackets.Auction
{
    [PacketHeader("rc_blist")]
    public class RcbListPacket : PacketBase
    {
        [PacketIndex(0)]
        public long PageIndex { get; set; }

        [PacketIndex(1, SpecialSeparator = "|")]
        public List<RcbListElementPacket?>? Items { get; set; }

        public class RcbListElementPacket : PacketBase
        {
            [PacketIndex(0)]
            public long AuctionId { get; set; }

            [PacketIndex(1)]
            public long OwnerId { get; set; }

            [PacketIndex(2)]
            public string? OwnerName { get; set; }

            [PacketIndex(3)]
            public long ItemId { get; set; }

            [PacketIndex(4)]
            public short Amount { get; set; }

            [PacketIndex(5)]
            public bool IsPackage { get; set; }

            [PacketIndex(6)]
            public long Price { get; set; }

            [PacketIndex(7)]
            public long MinutesLeft { get; set; }

            /// <summary>
            ///     Todo find signification but default known value is 2
            /// </summary>
            [PacketIndex(8)]
            public bool Unknown1 { get; set; }

            [PacketIndex(9)]
            public long Unknown { get; set; }

            [PacketIndex(10)]
            public long Rarity { get; set; }

            [PacketIndex(11)]
            public long Upgrade { get; set; }

            [PacketIndex(12, RemoveHeader = true)]
            public EInfoPacket? EInfo { get; set; }
        }
    }
}