using System;
using System.Collections.Generic;
namespace LostArkLogger
{
    public partial class PKTStatusEffectRemoveNotify
    {
        public void KoreaDecode(BitReader reader)
        {
            InstanceIds = reader.ReadList<UInt32>();
            ObjectId = reader.ReadUInt64();
            Reason = reader.ReadByte();
        }
    }
}
