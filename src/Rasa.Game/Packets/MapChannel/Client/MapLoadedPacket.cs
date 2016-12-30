﻿namespace Rasa.Packets.MapChannel.Client
{
    using Data;
    using Memory;

    public class MapLoadedPacket : PythonPacket
    {
        public override GameOpcode Opcode { get; } = GameOpcode.MapLoaded;
        
        public override void Read(PythonReader pr)
        {
        }

        public override void Write(PythonWriter pw)
        {
        }
    }
}