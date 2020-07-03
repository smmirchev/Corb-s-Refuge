# Corb-s-Refuge

## Getting Started
Unity version **Unity3D 2018.4.10f1** must be installed to run this software.
Visual Studio 2019 or newer version is required to avoid bugs.
Download all the files and open part3.sln with Visual Studio.

### Game Structure
Main menu/option menu is implemented and can be accessed by pressing the Escape key. The menu is created in a non-playable scene and it looks the following way:

<img src="https://github.com/smmirchev/Corb-s-Refuge/blob/master/images/menu1.png">

New Game starts a new game, Options opens a different menu and Quit exits the game.
Each one of the options is a button drawn on a canvas that calls a function when clicked. 
Clicking Options disables the above shown options and displays new options, which look like this:

<img src="https://github.com/smmirchev/Corb-s-Refuge/blob/master/images/menu2.png">

Difficulty and Sound are text while the rest are buttons. Clicking on Easy or Hard makes the enemies stronger. 

### Gameplay
There are two playable scenes, both of which use terrain and have fade in/out transition. When the player passes through a tomb gate (collides with an invisible object) a function is called that will flash the transition animation and load the scene. 
The player starts without weapons and deals 10 damage per second to enemies. There are two weapons that can be found and equipped – axe and mace. Equipping the axe increases the damage to 15, the mace to 20. The player can equip weapons by pressing “F” while near the weapons.
<img src="https://github.com/smmirchev/Corb-s-Refuge/blob/master/images/weapon.png">

### Art
Each scene has a unique background music playing.
There is a directional light (pointing from the direction of the sun) and a spotlight, which follows the player and brightens the area around them.
The camera is coded to follow the player behind their back as in third-person games.
The camera can be freely moved by clicking and holding the right mouse button. In addition, the player will move in the direction the camera is facing just by holding “W”.
Particle effects from static emitters are used inside the tomb.
A lot of materials /shaders, a skybox, fog and assets from the asset store are used to make the feeling of playing more immersive. Here are some pictures from the game:
<img src="https://github.com/smmirchev/Corb-s-Refuge/blob/master/images/env1.png">
<img src="https://github.com/smmirchev/Corb-s-Refuge/blob/master/images/env2.png">
<img src="https://github.com/smmirchev/Corb-s-Refuge/blob/master/images/env3.png">

### AI Artifacts
There is only one type of enemy, which is animated and uses NavMesh. The zombie is fully animated – it will stay in an idle state and walk to the player and attack them when the player enters their radius.

## Author
* Stefan Mirchev

## References
* [Standard Assets, by Unity Technologies](https://assetstore.unity.com/packages/essentials/asset-packs/standard-assets-for-unity-2017-3-32351)
* [POLYDesert, by Runemark Studio](https://assetstore.unity.com/packages/3d/environments/landscapes/polydesert-107196)
* [Free Fantasy Adventure Music Pack, by Creze Music Productions](https://assetstore.unity.com/packages/audio/music/orchestral/free-fantasy-adventure-music-pack-118684)
* [Low Poly Cowboy, by Malbers Animations](https://assetstore.unity.com/packages/3d/characters/humanoids/low-poly-cowboy-49698)
* [Melee Axe Pack, by Mixamo](https://assetstore.unity.com/packages/3d/animations/melee-axe-pack-35320)
* [Classic Skybox, by Mgsvevo](https://assetstore.unity.com/packages/2d/textures-materials/sky/classic-skybox-24923)
* [Mountains Canyons Cliffs, by Infinita Studio](https://assetstore.unity.com/packages/3d/environments/landscapes/mountains-canyons-cliffs-53984)
* [Stylized Terrain Texture, by Lowpoly](https://assetstore.unity.com/packages/2d/textures-materials/floors/stylized-terrain-texture-153469)
* [Desert Kits 64 Sample, by 256PX](https://assetstore.unity.com/packages/3d/environments/landscapes/desert-kits-64-sample-86482)
* [Tent_CR_MAX_550, by Crossroad_Max](https://assetstore.unity.com/packages/3d/environments/fantasy/tent-cr-max-550-118703)
* [Free Stylised Fantasy Weapons, by Vertexfrog](https://assetstore.unity.com/packages/3d/props/weapons/free-stylised-fantasy-weapons-77078)
* [Zombie, by Pxltiger](https://assetstore.unity.com/packages/3d/characters/humanoids/zombie-30232)
* [Fantasy Sfx, by Little Robot Sound Factory](https://assetstore.unity.com/packages/audio/sound-fx/fantasy-sfx-32833)
