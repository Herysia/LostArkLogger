using System;
using System.Collections.Generic;
namespace LostArkLogger
{
    public partial class StatusEffectData
    {
        public void SteamDecode(BitReader reader)
        {
            EffectInstanceId = reader.ReadUInt32();
            InstanceId = reader.ReadUInt64();
            SourceId = reader.ReadUInt64();
            bytearraylist = reader.ReadList<Byte[]>(7);
            SkillLevel = reader.ReadByte();
            u32 = reader.ReadUInt32();
            b_0 = reader.ReadByte();
            hasValue = reader.ReadByte();
            if (hasValue == 1)
                Value = reader.ReadBytes(16);
            s64 = reader.ReadSimpleInt();
            b_1 = reader.ReadByte();
            if (b_1 == 1)
                u64 = reader.ReadUInt64();
            StatusEffectId = reader.ReadUInt32();
        }
    }
}
