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
    public class PKTParalyzationStateNotify
    {
        public PKTParalyzationStateNotify(BitReader reader)
        {
            Unk0 = reader.ReadBytes(31);
        }

        public byte[] Unk0 { get; }
    }
}