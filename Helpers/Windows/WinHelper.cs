// COPYRIGHT (C) HARRY CLARK 2025
// .NET IMPLEMENTATION OF MEMORY HOOKS AND MANAGEMENT

// THIS FILE PERTAINS TOWARDS THE MODULARISATION OF METHODS INDICATIVE OF
// SPECIFIC OS PROCESSES

namespace revoMem.Helpers;

using System.Runtime.InteropServices;

public static partial class WinHelper
{
    /// <summary>
    /// READSA DATA FROM A SPECIFIC AREA OF MEMORY IN A SPECIFIED PROCESS
    /// ENCOMPASSING A GENERAL HANDLER FOR THE PROCESS WHICH LOKKS TO DETERMINE
    /// THE GENERAL MEMORY BEING READ
    /// </summary>
    /// <param name="PROCESS"></param>
    /// <param name="BASE_ADDR"></param>
    /// <param name="BUFFER"></param>
    /// <param name="SIZE"></param>
    /// <param name="BYES_READ"></param>
    /// <returns></returns>

    [DllImport("kernel32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool READ_PROCESS_MEMORY(IntPtr PROCESS, UIntPtr BASE_ADDR, UIntPtr BUFFER, UIntPtr SIZE,
        out UIntPtr BYTES_READ);
} 