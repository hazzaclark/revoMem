// COPYRIGHT (C) HARRY CLARK 2025
// DOCUMENTATION RESEARCH ON WORKING WITH MARIO KART WII'S MEMORY

// THE FOLLOWING PERTAINS TOWARDS THE BASE OF MEMORY ALLOCATION
// AND THE MODULARISATION ENCOMPASSING THE LOGIC BEHIND IT

using System.Data.SqlTypes;
using System.Diagnostics;
using System.Drawing;
using System.Reflection.Metadata.Ecma335;
using revoMem.Memory.Interfaces;

namespace revoMem.Memory;

public abstract class AbstractMemory
{
    /// <summary>
    /// CONVERTS A BYTE ARRAY TO A GENERIC OBJECT
    /// THIS HELPS ESPECIALLY WHEN BEING ABLE TO CREATE SAFER READS AND WRITES
    /// </summary>
    /// <param name="MEMORY"></param>
    /// <param name="BYTES"></param>
    /// <param name="OFFSET"></param>
    /// <returns></returns>
    public abstract unsafe object FROM_BYTES(void* MEMORY, byte[] BYTES, int OFFSET);

    /// <summary>
    /// NOW DO THE SAME AS ABOVE BY FOR TOWARDS THE OFFSET
    /// </summary>
    /// <param name="MEMORY"></param>
    /// <param name="BYTES"></param>
    /// <param name="OFFSET"></param>
    /// <returns></returns>
    public abstract unsafe object TO_BYTES(void* MEMORY, byte[] BYTES, int OFFSET);


    /// <summary>
    /// THIS ENCOMPASSES A GENERIC READ THAT DOESNT INCLUDE RAW BYTES
    /// INSTEAD, THIS WILL BE INCOPERATED UNDER THE ASSUMPTION OF A STREAM
    /// </summary>
    /// <param name="MEMORY"></param>
    /// <param name="ADDRESS"></param>
    /// <returns></returns>
    public unsafe object READ(void* MEMORY, uint ADDRESS)
    {
        byte[] BYTES = ProcessMemory.INSTANCE.READ_BYTES(ADDRESS, (uint)MEMORY);
        return FROM_BYTES(MEMORY, BYTES, 0);
    }
}