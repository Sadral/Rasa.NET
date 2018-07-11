﻿namespace Rasa.Packets.MapChannel.Server
{
    using Data;
    using Memory;

    public class DestroyPhysicalEntityPacket : PythonPacket
    {
        public override GameOpcode Opcode { get; } = GameOpcode.DestroyPhysicalEntity;

        public uint EntityId { get; set; }

        public DestroyPhysicalEntityPacket(uint entityId)
        {
            EntityId = entityId;
        }

        public override void Read(PythonReader pr)
        {
        }

        public override void Write(PythonWriter pw)
        {
            pw.WriteTuple(1);
            pw.WriteInt((int)EntityId);
        }
    }
}