/*
 * This file has been Auto Generated, Please do not edit.
 * If you need changes, follow the instructions written in the readme.md
 *
 * Generated by Herysia.
 */

using System;
using System.Collections.Generic;
using LostArkLogger.Types;

namespace LostArkLogger
{
    public class PKTStatChangeOriginNotify
    {
        public PKTStatChangeOriginNotify(BitReader reader)
        {
            StatPairList = new StatPair(reader);
            Unk1 = reader.ReadByte();
            if(Unk1 == 1)
            {
                Unk1_0 = reader.ReadInt32();
            }
            StatPairChangedList = new StatPair(reader);
            ObjectId = reader.ReadUInt64();
            Unk4 = reader.ReadByte();
        }

        public StatPair StatPairList { get; } = new StatPair();
        public byte Unk1 { get; }
        public int Unk1_0 { get; }
        public StatPair StatPairChangedList { get; } = new StatPair();
        public ulong ObjectId { get; }
        public byte Unk4 { get; }
    }
}