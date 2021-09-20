# Road to Nowhere

`insert gifs here`

## About

AR Application that has nonsensical representations of New York, New York and Rome, Italy in miniature souvenir form.  
The application fixes these 3D knickknacks / doodads / souvenirs on top of marker cubes (found below).  
These cubes display the weather, an interactive magic 8 cube (rotate 180° in one direction, then back), and some visual elements that (obscurely) represent their respective areas.  
These cubes can also be affixed to a plane using Vuforia's plane recognition - in this mode, the cubes are static but much larger.

## Requirements

- [Unity Editor 2019.4.28f1](https://unity3d.com/get-unity/download/archive)
  - Modules
    - Android Build Support
    - Android SDK & NDK (can also be installed independently)
    - OpenJDK (can also be installed independently)
  - Packages
    - TextMeshPro 2.1 (included)
    - Vuforia 9.8.11 (included)
- External Assets [as listed below](#external-assets)
  - Included, probably shouldn't be though.
- [2 marker cubes](https://www.evl.uic.edu/aej/428/CubesForVuforia.zip)

## How to build

1. Download the source to the [latest release](https://github.com/pizzatree/428P1/releases)

2. Open/import the project using your [preferred mechanism](https://docs.unity3d.com/2019.4/Documentation/Manual/GettingStartedOpeningProjects.html)

3. Follow the appropriate instructions to build to your [recommended devices](https://library.vuforia.com/platform-support/vuforia-engine-recommended-devices.html)
   - [Android](https://docs.unity3d.com/2019.4/Documentation/Manual/android-BuildProcess.html)
   - [iOS](https://docs.unity3d.com/2019.4/Documentation/Manual/UnityCloudBuildiOS.html)
   - If having build issues, try [disabling IL2CPP](https://docs.unity3d.com/2019.4/Documentation/Manual/IL2CPP.html)

## External Assets

- Visuals
  - [Turtle Model by Acord Bringer](https://assetstore.unity.com/packages/3d/environments/simplistic-low-poly-nature-93894)
  - [Multiple awesome materials by ambientCG](https://ambientcg.com/)
  - [Colosseum by markdw1](https://www.turbosquid.com/3d-models/free-blend-model-roman/331374)
  - [Manhole texture by Bearded Man Studios](https://assetstore.unity.com/packages/2d/textures-materials/manhole-4454)
  - [Fire Hydrant by Anton Cox](https://assetstore.unity.com/packages/3d/props/exterior/photorealistic-fire-hydrants-139515)
  - [Naked guy by Milos Baskic](https://assetstore.unity.com/packages/3d/characters/humanoids/humans/human-3d-project-animated-handpainted-male-69507)
  - [NYC Logo Art](https://www.vexels.com/png-svg/preview/145773/new-york-city-logo)
  - [Rome Logo Art](https://dribbble.com/shots/457891-Rome-logo)
  - [Pizza model](https://open3dmodel.com/3d-models/pepperoni-pizza_477512.html)
  - [Steak texture by TextureCan](https://www.texturecan.com/details/232/)
  - [Tiny Tiger by Vicarious Visions / Traveller's Tales](https://www.deviantart.com/sab64/art/MMD-XPS-Model-Tiny-Tiger-CNK-Download-667532513)
- Audio
  - [Magic 8 Sound by Mike Koenig](https://soundbible.com/1601-Mario-Jumping.html)
  - [Roaring Lion by Mike Koenig](https://soundbible.com/1272-Roaring-Lion.html)
  - [Spiderman 2 (2004) Pizza Theme by Treyarch](https://archive.org/details/SpiderMan2TheGamePizzaTheme)
