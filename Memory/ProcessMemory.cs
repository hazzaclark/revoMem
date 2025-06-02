// COPYRIGHT (C) HARRY CLARK 2025
// DOCUMENTATION RESEARCH ON WORKING WITH MARIO KART WII'S MEMORY

// THIS FILE PERTAINS TOWARDS THE LOGIC ENCOMPASSING MY TAKE ON THE PROCESS MEMORY
// IN TURN, THIS WILL ALLOW FOR FULL MODULAR CONTROL IN HOOKING MEMORY MORE EFFICIENTLY
// BASED ON EVENTS

using revoMem.Memory.Interfaces;
using System.Runtime.CompilerServices;

namespace revoMem.Memory;

public unsafe partial struct ProcessMemory : MemoryAccess
{
    public static readonly ProcessMemory INSTANCE = new();

    /// <summary>
    /// READS RAW BYTES FROM A SPECIFIED MEMORY OFFSET
    /// WRITES THOSE CONTENTS INTO THE PROVIDED SPAN WHICH ENCOMPASSING AN ARBITRARY MEMORY REGION
    /// </summary>
    /// <param name="OFFSET">THE MEMORY ADDRESS TO READ FROM</param>
    /// <param name="VALUE">THE DESTINATION SPAN WHERE THE READ BYTES WILL BE WRITTEN TO</param>
    /// <remarks>
    /// THE METHOD IN QUESTION PERFORMS AN UNALIGNED MEMORY COPY WHICH ASSUMES THAT THE SOURCE MEMORY REGION
    /// IS ASSOCIATED WITH THE CURRENT OFFSET, AS WELL AS IT BEING VALID TO BEGIN WITH
    /// </remarks>
    public void READ_RAW(uint OFFSET, Span<byte> VALUE)
    {
        fixed (byte* RESULT = VALUE)
        {
            Unsafe.CopyBlockUnaligned(RESULT, (void*)OFFSET, (uint)VALUE.Length);
        }
    }

    /// <summary>
    /// DO THE SAME UNALIGNED MEMORY SCHEME BUT FOR WRITES 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="OFFSET"></param>
    /// <param name="BASE"></param>

    public void WRITE<T>(uint OFFSET, T BASE)
    {
        Unsafe.WriteUnaligned((void*)OFFSET, BASE);
    }
}
