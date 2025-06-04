// COPYRIGHT (C) HARRY CLARK 2025
// DOCUMENTATION RESEARCH ON WORKING WITH MARIO KART WII'S MEMORY

// THIS FILE PERTAINS TOWARDS THE LOGIC ENCOMPASSING MY TAKE ON THE PROCESS MEMORY
// IN TURN, THIS WILL ALLOW FOR FULL MODULAR CONTROL IN HOOKING MEMORY MORE EFFICIENTLY
// BASED ON EVENTS

using revoMem.Memory.Interfaces;

namespace revoMem.Memory;

public abstract class DolphinProcess : IDolphinProcess
{
    public bool FIND_PID()
    {
        return true;
    }
}