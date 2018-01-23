﻿namespace Rasa.Packets.MapChannel.Server
{
    using Data;
    using Memory;

    public class AckPingPacket : PythonPacket
    {
        public override GameOpcode Opcode { get; } = GameOpcode.AckPing;

        public double ClientTime { get; set; }

        public AckPingPacket(double clientTime)
        {
            ClientTime = clientTime;
        }

        public override void Read(PythonReader pr)
        {
        }

        public override void Write(PythonWriter pw)
        {
            pw.WriteTuple(1);
            pw.WriteDouble(ClientTime);
        }
    }
}
