# Unity 3D Car Driving Simulation

## Overview

This project is a basic car driving simulation created in Unity, designed to evaluate proficiency in Unity 3D game development. The project consists of two main parts:

1. **Car Mechanics and Level Design**: A functional 3D car with realistic driving physics and a challenging off-road level with various obstacles.
2. **Game Menu UI**: A simple game menu designed to resemble the layout of Sniper 3D's main menu.

## Features

### Part 1: Car Mechanics and Level Design

- **3D Car Mechanics**:
  - Realistic driving physics using Unity's `Rigidbody` and `Wheel Collider` components.
  - Smooth acceleration, braking, and steering controls.
  - Visual updates for wheel positions and rotations.

- **Off-Road Level**:
  - A custom-designed terrain with hills, valleys, and uneven surfaces.
  - Various obstacles, including rocks, speed breakers, and ditches, providing a challenging driving experience.

### Part 2: Game Menu UI

- **Main Menu**:
  - A simple UI layout inspired by Sniper 3D's menu design.
  - Includes "Play", "Options", and "Exit" buttons (UI functionality not implemented).

## Project Structure

- **Assets**:
  - `CarController.cs`: Script controlling car movement and physics.
  - `MainMenu.cs`: Script for handling UI button interactions (optional).
  - `OffRoadScene`: The main scene with the terrain, car, and obstacles.
  - `MainMenuScene`: The scene containing the main menu UI.

- **Scenes**:
  - `OffRoadScene`: Contains the off-road level and car mechanics.
  - `MainMenuScene`: Contains the main menu UI.

## Getting Started

### Prerequisites

- Unity 2020.3 or later.

### Running the Project

1. Clone the repository or download the project files.
2. Open the project in Unity.
3. Load the `MainMenuScene` or `OffRoadScene` from the Project window.
4. Press the Play button in the Unity Editor to start the simulation.

### Controls

- **W/S or Up/Down Arrow**: Accelerate/Brake
- **A/D or Left/Right Arrow**: Steer Left/Right

## Future Improvements

- Implement functionality for the main menu buttons.
- Add more realistic car models and animations.
- Expand the off-road level with additional obstacles and challenges.
- Enhance the car physics for better realism.

## Acknowledgments

- Unity for providing powerful tools for game development.
- The developers of Sniper 3D for inspiring the UI design.

