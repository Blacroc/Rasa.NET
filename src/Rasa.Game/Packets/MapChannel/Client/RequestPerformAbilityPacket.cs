﻿using System;

namespace Rasa.Packets.MapChannel.Client
{
    using Data;
    using Memory;

    public class RequestPerformAbilityPacket : PythonPacket
    {
        public override GameOpcode Opcode { get; } = GameOpcode.RequestPerformAbility;

        public int ActionId { get; set; }
        public int ActionArgId { get; set; }
        public long Target { get; set; }
        public int ItemId { get; set; }

        public override void Read(PythonReader pr)
        {
            Console.WriteLine("RequestPerformAbility\n{0}", pr.ToString());
            pr.ReadTuple();
            ActionId = pr.ReadInt();
            ActionArgId = pr.ReadInt();
            Target = pr.ReadLong();
            if (pr.PeekType() == PythonType.Int)
                ItemId = pr.ReadInt();
            else
                pr.ReadNoneStruct();
        }

        public override void Write(PythonWriter pw)
        {
        }
    }
}