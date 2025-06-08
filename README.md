# revoMem
.NET implementation of Memory Hooks and Management (x86_64)

# Motive:

The following project aims to provide a lightweight and seamless means of making conducive works out of the Memory Scheme of common x86_64 processes.

Originally, this project was limited mostly to uncovering the structural integrity of Mario Kart Wii, though as the project has expanded and motives have changed, I aim to provide a surrogate means of hooking, uncovering and determining the basis of common Memory Management processes in applications.

Inspired mostly by the fruitful efforts of the [Dolphin Memory Engine](https://github.com/aldelaro5/dolphin-memory-engine/), this aims to be an abstraction of said functionality but specifically focussing on the structures and innate workings of a traditional process.

This project is scalible and portable and the build outcome will be entirely deterministic based on the OS of choice - through the usage of definers for each OS type

# Building:

For this project, you will need the latest version of  [.NET 4.8 Runtime](https://dotnet.microsoft.com/en-us/download/dotnet-framework/thank-you/net48-developer-pack-offline-installer)

From there, it is a case of running ``dotnet build`` and running the program.

As the project expands, I aim to provide a console window which provides conducive, real-time Memory R/W updates as well as a seperate build for DLL injections

# Sources:

[Dolphin Memory Engine](https://github.com/aldelaro5/dolphin-memory-engine/)

[ReloadedMemory](https://github.com/Reloaded-Project/Reloaded.Memory)
