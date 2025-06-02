# revoMem
A study into the Memory Management and Hooks of Mario Kart Wii

# Motive:

The following project aims to provide a lightweight and seamless means of making conducive works out of the Memory Scheme in Mario Kart Wii.

In turn, this project aims to abstract the need for intrinsic and maticulous patching of DOL files in order to learn more about the games inner-workings.

Inspired mostly by the fruitful efforts of the [Dolphin Memory Engine](https://github.com/aldelaro5/dolphin-memory-engine/), this aims to be an abstraction of said functionality but specifically focussing on the structures and globals defined in Mario Kart Wii.

The end goal with this project is to finally provide an ease-of-use means of hooking Discord Rich Presence to [WheelWizard](https://github.com/TeamWheelWizard/WheelWizard/)

# Building:

For this project, you will need the latest version of  [.NET 4.8 Runtime](https://dotnet.microsoft.com/en-us/download/dotnet-framework/thank-you/net48-developer-pack-offline-installer)

From there, it is a case of running ``dotnet build`` and running the program.

As the project expands, I aim to provide a console window which provides conducive, real-time Memory R/W updates as well as a seperate build for DLL injections

# Sources:

[Dolphin Memory Engine](https://github.com/aldelaro5/dolphin-memory-engine/)

[ReloadedMemory](https://github.com/Reloaded-Project/Reloaded.Memory)
