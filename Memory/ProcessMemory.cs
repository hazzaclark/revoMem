// COPYRIGHT (C) HARRY CLARK 2025
// DOCUMENTATION RESEARCH ON WORKING WITH MARIO KART WII'S MEMORY

// THIS FILE PERTAINS TOWARDS THE LOGIC ENCOMPASSING MY TAKE ON THE PROCESS MEMORY
// IN TURN, THIS WILL ALLOW FOR FULL MODULAR CONTROL IN HOOKING MEMORY MORE EFFICIENTLY
// BASED ON EVENTS

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

using revoMem.Memory.Structs;

namespace revoMem.Memory;

public class ProcessMemory : IDisposable
{
    public ProcessMemory() {}

    public void Dispose()
    {

    }
}