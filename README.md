# Grabb Grab Grub
Play as Grabb, an insatiably hungry chameleon, and catch bugs to eat with your tongue!

## Overview
Catch a certain number of bugs within the time limit to finish the level! You will be presented with a chameleon fact and that choice to proceed to the next level.

## To-do
Conservation of tasks: Each time I complete a task, I realize there is one I forgot to account for and add it to the list...
### Programming
#### Tongue
- [x] Projectile returns to original position upon reaching clicked point
- [x] Projectile returns to original position upon collision
- [x] ~~Either~~ fix projectile position when not shooting ~~or pool it (if this, remember `OnEnable()`)~~
- [x] BUG FIX: Projectile jumps to click if click happens right during/after collision
- [ ] Pretty serious issue: since projectile stays in scene, it still interacts w/ the bugs that touch it even if it doesn't launch. Result of poorly organized code that it's not trivial for me to figure out how to fix. Feature, not a bug?? Who can blame the chameleon for eating a bug that flies straight into its mouth??
- [x] Use a LineRenderer (thanks Athena!)
- [ ] ~~Powerups for tongue strength (idea from Ming)~~ too RNG-based for this to make sense
#### Bugs
- [x] Spawn in bugs to be caught
- [x] Deactivate bugs upon exiting screen
- [x] Keep track of bugs caught
- [x] More interesting bug movement
- [x] Attach bugs to tongue upon collision
#### Levels
- [x] Timer
- [ ] ~~Proceed to different levels~~ this game is too RNG-based for scaling difficulty to make sense :()
- [ ] ~~Change parameters for further levels~~
- [x] Random chameleon fact upon level completion
#### Menus and options
- [ ] Main menu
- [ ] Pause menu
- [ ] Audio options
#### Cleanup
- [x] Remove unnecessary stuff from repo since I initially forgot the gitignore....

### Art and Music
- [ ] Draw chameleon w/ separated head and tongue
- [ ] Draw bugs
- [ ] Draw background
- [ ] UI elements
- [ ] ~~Draw powerups~~
- [ ] Chill background music
- [ ] SFX for catching bug, slurping up bug, ~~powerups~~
- [ ] Animation............
