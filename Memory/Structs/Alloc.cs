// COPYRIGHT (C) HARRY CLARK 2025
// .NET IMPLEMENTATION OF MEMORY HOOKS AND MANAGEMENT

// THE FOLLOWING PERTAINS TOWARDS THE BASE OF MEMORY ALLOCATION
// AND THE MODULARISATION ENCOMPASSING THE LOGIC BEHIND IT

namespace revoMem.Memory.Structs;

public struct Alloc
{
    /// <summary>
    /// THE ADDRESS OF THE STORED MEMORY
    /// </summary>
    public uint ADDRESS;

    /// <summary>
    /// THE LENGTH OF THE MEMORY ADDRESS
    /// </summary>
    public uint LENGTH;

    /// <summary>
    /// THE SIZE OF THE MEMORY ADDRESS
    /// </summary>
    public uint SIZE;

    public Alloc() { }

    public Alloc(UIntPtr ADDR, UIntPtr LEN)
    {
        ADDR = ADDRESS;
        LEN = LENGTH;
    }
}