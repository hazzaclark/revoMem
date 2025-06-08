// COPYRIGHT (C) HARRY CLARK 2025
// .NET IMPLEMENTATION OF MEMORY HOOKS AND MANAGEMENT

// THE FOLLOWING PERTAINS TOWARDS THE BASE OF MEMORY ALLOCATION
// AND THE MODULARISATION ENCOMPASSING THE LOGIC BEHIND IT

// THIS FILE MORESO ENCOMPASSES THE EXTENSION METHODS USED TO BE 
// ABLE TO MAKE CONCLUSIVELY ASSERTIONS OF THE CHANGES IN MEMORY PROTECTION

using revoMem.Memory.Interfaces;
using revoMem.Memory.Structs;

namespace revoMem.Memory;

public static class MemoryExtensions
{
    /// <summary>
    /// ACCOUNTS FOR THE SAFE CHANGE IN TYPE PROTECTION
    /// // THIS IS BY SAFELY DETERMINING THE NEW VALUE HOUSES AT THE PROTECTOR AGAINST THE MEMORY ADDRESS
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="BASE"></param>
    /// <param name="MEM_ADDRESS"></param>
    /// <param name="SIZE"></param>
    /// <param name="NEW_LEVEL"></param>
    /// <returns></returns>
    public static uint CHANGE_PROTECTION<T>(this T BASE, uint MEM_ADDRESS, int SIZE, MemoryProtection NEW_LEVEL)
    {
        return BASE.CHANGE_PROTECTION(MEM_ADDRESS, SIZE, NEW_LEVEL);
    }
    
    /// <summary>
    /// ASSIGN A NEW TYPE OF THE DISPOSABLE ALLOCATOR TO BE ABLE TO CONTROL THE FLOW
    ///  OF EXECUTABLE MEMORY IN AND OUT OF THE PROTECTION LAYER
    /// THIS PENULTIMATELY WORKS WITH READ AND WRITES EXTENSIONS 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="BASE"></param>
    /// <param name="MEM_ADDRESS"></param>
    /// <param name="SIZE"></param>
    /// <param name="NEW_LEVEL"></param>
    /// <returns></returns>

    public static IDisposeAlloc<T> CHANGE_DISP<T>(this T BASE, uint MEM_ADDRESS, int SIZE, IDisposeAlloc<T> NEW_LEVEL) where T : MemoryProtection
    {
        return new IDisposeAlloc<T>
        {
            MEMORY_ADDRESS = MEM_ADDRESS,
            PROTECTION = BASE,
            SIZE = SIZE
        };
    }
}