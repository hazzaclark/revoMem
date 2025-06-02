// COPYRIGHT (C) HARRY CLARK 2025
// DOCUMENTATION RESEARCH ON WORKING WITH MARIO KART WII'S MEMORY

// THE FOLLOWING PERTAINS TOWARDS THE BASE OF MEMORY ALLOCATION
// AND THE MODULARISATION ENCOMPASSING THE LOGIC BEHIND IT

// THIS FILE MORESO ENCOMPASSES THE SAFE DISPOSABLE OF UNWARRANTED MEMORY ACCESSES
// IN LOCATIONS BY WHICH THEY ARE OUT OF BOUNDS - PROVIDING A SAFE MEANS OF DEALLOC

using System.Collections.Generic;
using revoMem.Memory.Interfaces;

namespace revoMem.Memory.Structs;

public readonly struct IDisposeAlloc<T> : IDisposable where T : MemoryProtection
{
    /// <summary>
    /// THE MEMORY ADDRESS WHEREBY IT NEEDS TO ENCAPSULATE THE PROTECTION
    /// </summary>
    public uint MEMORY_ADDRESS { get; init; }

    /// <summary>
    /// THE BASE ADDRESS AT WHICH THE PROTECTION WAS INITIALISED
    /// </summary>
    public uint BASE_PROTECTION { get; init; }


    /// <summary>
    /// THE SIZE OF THE MEMORY
    /// </summary>
    public int SIZE { get; init; }

    public void Dispose()
    {
        
    }
    
}
