// COPYRIGHT (C) HARRY CLARK 2025
// DOCUMENTATION RESEARCH ON WORKING WITH MARIO KART WII'S MEMORY

// THE FOLLOWING PERTAINS TOWARDS THE BASE OF MEMORY ALLOCATION
// AND THE MODULARISATION ENCOMPASSING THE LOGIC BEHIND IT

using System.Runtime.CompilerServices;
using revoMem.Memory;
using revoMem.Memory.Structs;

public interface MemoryAccess
{
    /// <summary>
    /// READ RAW DATA FROM A SPECIFIED MEMORY ADDRESS
    /// ENCOMPASSING THE MEMORY SAFETY OF IT'S CONTEMPORARIES
    /// THIS WILL UTILISE THE USAGE OF SPAN
    /// 
    /// WHICH IS THE DELEGATE OF BEING ABLE TO ARBITRARILY READ A CONTINGUOUS REGION OF MEMORY
    /// WITHIN A SPECIFIED RANGE
    /// </summary>
    /// <param name="OFFSET"></param>
    /// <param name="VALUE"></param>
    void READ_RAW(uint OFFSET, Span<byte> VALUE);


    /// <summary>
    /// WRITE A GENERIC TYPE TO AN ARBIRARY MEMORY ADDRESS
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="OFFSET"></param>
    /// <param name="BASE"></param>
    void WRITE<T>(uint OFFSET, T BASE);
}