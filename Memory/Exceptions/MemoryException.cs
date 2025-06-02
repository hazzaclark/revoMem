// COPYRIGHT (C) HARRY CLARK 2025
// DOCUMENTATION RESEARCH ON WORKING WITH MARIO KART WII'S MEMORY

// THE FOLLOWING PERTAINS TOWARDS THE BASE OF MEMORY ALLOCATION
// AND THE MODULARISATION ENCOMPASSING THE LOGIC BEHIND IT

// MOREOVER, THIS FILE AIMS TO PROVIDE A SURROGATE MEANS 
// OF PROVIDING A CUSTOM EXCEPTION HANDLER TO GAIN FULL CONTROL
// OVER THE FLOW AND EXECUTION OF MEMORY

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using revoMem.Memory.Structs;

namespace revoMem.Memory.Exceptions;

[Serializable]
public class MemoryException : Exception
{
    /// <summary>
    /// DUMMY VARIABLES DESIGNED TO PROVIDE MORE LIASSE 
    /// FOR THE MEMORY ACCESSS - WITHOUT INCLUDING THE INTERFACES
    /// WHICH INCLUDE THESE METHODS 
    /// </summary>
    public uint MEMORY_ADDRESS { get; }

    public uint SIZE { get; }

    /// <summary>
    /// DUMMY CONSTRUCTOR FOR HANDLING
    /// </summary>
    public MemoryException() { }

    /// <summary>
    /// CONSTRUCTOR FOR A SIMPLE MESSAGE
    /// </summary>
    /// <param name="MESSAGE"></param>
    public MemoryException(string MESSAGE) : base(MESSAGE) { }


    /// <summary>
    /// SERIALISED FIELD FOR HANDLING TYPE-SPECIFIC OPERATIONS
    /// </summary>
    /// <param name="INFO"></param>
    public MemoryException(SerializationInfo INFO)
    {
        MEMORY_ADDRESS = INFO.GetUInt32(nameof(MEMORY_ADDRESS));
    }
}