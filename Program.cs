// COPYRIGHT (C) HARRY CLARK 2025
// DOCUMENTATION RESEARCH ON WORKING WITH MARIO KART WII'S MEMORY

using System;
using System.Diagnostics;
using System.Threading.Tasks;

using revoMem.Memory;

namespace revoMem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HARRY CLARK - REVOMEM (A STUDY INTO MKW MEMORY)\n");

            MEM_SIM();
        }

        /// <summary>
        /// FOR THE TIME BEING, WE WILL HAVE AN ARBITRARY BUFFER WHICH 
        /// DELEGATES ENOUGH SPACE FOR VALUES TO BE READ AND WRITTEN TO AND FROM
        /// 
        /// THIS IS A VERY BASIS SEMANTIC OF WHAT I HAVE IN MIND
        /// SO THIS IS IN NO WAY INDICATIVE OF THE FINAL RESULT
        /// 
        /// TODO: ENDIAN READER TO PROPERLY ENCAPSULATE THE MEMORY MANAGEMENT
        /// </summary>

        static unsafe void MEM_SIM()
        {
            Span<byte> READ_BUFFER = stackalloc byte[4];

            ProcessMemory.INSTANCE.READ(0, READ_BUFFER);
            Console.WriteLine($"ORIGINAL VALUE: 0x{BitConverter.ToUInt32(READ_BUFFER):X8}");

            uint VALUE_TO_WRITE = 0x10000000;
            ProcessMemory.INSTANCE.WRITE(0, VALUE_TO_WRITE);
            Console.WriteLine($"VALUE WRITTEN: 0x{VALUE_TO_WRITE:X8}");

            ProcessMemory.INSTANCE.READ(0, READ_BUFFER);
            Console.WriteLine($"VALUE READ BACK: 0x{BitConverter.ToUInt32(READ_BUFFER):X8}");
        }
    }
}
