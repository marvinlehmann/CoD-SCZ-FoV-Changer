# Call of Duty: SCZ FoV Changer
A non-multiplayer field of view changer for various Call of Duty games.

**SCZ** stands for: **S**ingleplayer + **C**O-OP + **Z**ombies

This field of view changer allows you to change the game variables **cg_fov** (0-360) and **cg_fovScale** (1.0 - 2.0) easily.
These variables can be changed with binds (bind KEY "cg_fov XX") in the single player mode but in co-op they are cheat/write protected. If you use this program, you don't need a console, a bind or even a modded version of the game to change the field of view to your liking. With an optimal field of view you won't experience eye strain, headaches or motion sickness. 

## Compatibility

### Supported games
- Call of Duty: World at War ( singleplayer, co-op, zombies (solo & co-op) )
- Call of Duty: Modern Warfare 2 ( singleplayer, special ops (solo & co-op) )
- Call of Duty: Black Ops 1 ( singleplayer, zombies (solo & co-op) )

### Requirements
- Windows Vista or newer
- .NET Framework 4.5


### Anti-Cheat (VAC & PunkBuster)
All supported CoDs don't use VAC or PunkBuster in the singleplayer executables, so you should be on the safe side as long as you don't use it when cheat-secured games are running! 

**Nevertheless I am NOT responsible for any bans or damages! Use at your own risk!**


## Usage
1. Download the latest [release](https://github.com/marvinl97/CoD-SCZ-FoV-Changer/releases).
2. Start the FoV Changer and the game (the order doesn't matter) and choose your desired FoV. 
3. Keep it running because the FoV will be resetted in situations like respawns or map changes.

## Settings
- cg_fov : horizontal field of view
- cg_fovScale : scale applied to cg_fov (this changes the field of view in "Aim(ing) Down Sights" too)
- enable Beep : if checked, beep sounds will be enabled
- auto start : if checked, the selected CoD will be started automatically
- auto select CoD on startup : if checked, an active/running CoD will be auto selected if possible on startup

#### Start options:
You can pass a keyword as a start parameter to the field of view changer to auto select a specific CoD. The program chronologically checks the game titles and executable names for the keyword. 

Examples:

`CoD.SCZ.FoV.Changer.exe iw4sp` will select "Call of Duty: Modern Warfare 2"

`CoD.SCZ.FoV.Changer.exe "Black Ops"` will select "Call of Duty: Black Ops"

`CoD.SCZ.FoV.Changer.exe call` will select "Call of Duty: World at War" because it's the first item in the list

\* *The check is case-insensitive.*



Credits to **[AgentRev](https://github.com/AgentRev)** for the beep sounds!
