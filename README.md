# Car Game Project

## Overview

This Unity project is a simple car game where the player controls a car to collect randomly spawned coins while avoiding pedestrians crossing the road. The game ends if the car hits a pedestrian or the time limit runs out.

## Features

- **Player-controlled car**: Use keyboard controls to drive.
- **Randomly spawned coins**: Collect coins to increase your score.
- **Pedestrian crossing**: Avoid pedestrians who cross the road.
- **Game over conditions**: 
  - Hitting a pedestrian.
  - Time limit expiration.
- **Score tracking**: Earn points for each coin collected.

## Project Structure

    CarGame/
    ├── Assets/
    ├── Library/
    ├── Logs/
    ├── Packages/
    ├── ProjectSettings/
    ├── Temp/
    ├── UserSettings/
    ├── obj/
    ├── .vs/
    ├── .vsconfig
    ├── Assembly-CSharp.csproj
    ├── Practice_1.sln
    └── README.md


> **Note:** Most folders (Library, Logs, Temp, obj, etc.) are Unity or build-generated and typically should not be included in version control. Only `Assets`, `Packages`, and `ProjectSettings` are necessary for sharing the project.

## How to Play

1. **Start the game**: Press Play in the Unity Editor.
2. **Drive the car**: Use arrow keys or WASD to steer.
3. **Collect coins**: Drive over coins to collect them.
4. **Avoid pedestrians**: Do not hit crossing pedestrians.
5. **Game over**: The game ends if you hit a pedestrian or the timer reaches zero.

## Getting Started

1. Clone or download this repository.
2. Open the project in Unity (recommended: 2021.3 or newer).
3. Open the main scene from `Assets/Scenes`.
4. Press Play to start.

## Customization

- Adjust coin and pedestrian spawn rates in their respective scripts.
- Change the time limit in the GameManager script.
- Update controls in Unity's Input Manager if needed.

## Credits

- Developed as a Unity practice project.
- Assets used are original or from free Unity asset packs.

---

Enjoy playing!

