// COPYRIGHT (C) HARRY CLARK 2025
// .NET IMPLEMENTATION OF MEMORY HOOKS AND MANAGEMENT

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
    
    public T PROTECTION { get; init; }

    /// <summary>
    /// EXTENDED FUNCTIONALITY FROM THE BASE DISPOABLE INTERFACE
    /// AUTOMATICALLY DELEGATES TO NEW PROTECTION LAYER
    /// </summary>
    public void Dispose()
    {
        PROTECTION.CHANGE_PROTECTION_LAYER(MEMORY_ADDRESS, SIZE, BASE_PROTECTION);
    }
    
}