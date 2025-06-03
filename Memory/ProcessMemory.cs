// COPYRIGHT (C) HARRY CLARK 2025
// DOCUMENTATION RESEARCH ON WORKING WITH MARIO KART WII'S MEMORY

// THIS FILE PERTAINS TOWARDS THE LOGIC ENCOMPASSING MY TAKE ON THE PROCESS MEMORY
// IN TURN, THIS WILL ALLOW FOR FULL MODULAR CONTROL IN HOOKING MEMORY MORE EFFICIENTLY
// BASED ON EVENTS

using System.Runtime.CompilerServices;

using revoMem.Memory.Interfaces;
namespace revoMem.Memory;

public unsafe class ProcessMemory : MemoryAccess
{
    public static ProcessMemory INSTANCE = new();
    private byte[] BUFFER = new byte[sizeof(UIntPtr)];

    /// <summary>
    /// READ BYTES BASED ON A PRE-SUPPOSED BYTE BUFFER
    /// THIS IS TO ALLOW FOR SAFER CHECKS WHEN IT COMES TO THE ALLOCATION
    /// OF MEMORY STREAMS
    /// </summary>
    /// <param name="ADDRSSS"></param>
    /// <param name="LENGTH"></param>
    /// <returns></returns>
    public byte[] READ_BYTES(uint ADDRSSS, uint LENGTH)
    {
        checked
        {
            byte[] BUFFER = new byte[LENGTH];
            READ(ADDRSSS, BUFFER);
            return BUFFER;
        }
    }

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
    public void READ(uint OFFSET, Span<byte> VALUE)
    {
        fixed (byte* SOURCE = &BUFFER[OFFSET])
        fixed (byte* BUFFER = VALUE)
        {
            Unsafe.CopyBlock(BUFFER, SOURCE, (uint)VALUE.Length);
        }
    }

    /// <summary>
    /// DO THE SAME UNALIGNED MEMORY SCHEME BUT FOR WRITES 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="OFFSET"></param>
    /// <param name="BASE"></param>

    public unsafe void WRITE<T>(uint OFFSET, in T BASE) where T : unmanaged
    {
        fixed (byte* DEST = &BUFFER[OFFSET])
        {
            Unsafe.Write(DEST, BASE);
        }
    }
}
