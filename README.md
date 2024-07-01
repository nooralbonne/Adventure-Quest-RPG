# AdventureQuestRPG

This is a simple text-based RPG game project written in C#.

## Description

AdventureQuestRPG is a console application where a player battles against a monster. The game features turn-based combat mechanics where the player and the monster take turns attacking each other until one of them loses all their health points.

## Installation

To run this application, you need:

- Visual Studio (recommended) or any C# compiler.
- .NET Framework or .NET Core installed on your machine.

Clone this repository to your local machine using:

## How to Use

1. Open the solution in Visual Studio.
2. Set "AdventureQuestRPG" as the startup project.
3. Build and run the project.

## Gameplay

- The game starts with a player and a predefined monster.
- Each character has health points (HP), attack power, and defense stats.
- The player attacks first, followed by the monster.
- Damage calculation:
  - Player's damage = Player's Attack Power - Monster's Defense
  - Monster's damage = Monster's Attack Power - Player's Defense
- The battle continues until either the player or the monster's health drops to zero.

## Contributing

Contributions are welcome! If you find any bugs or have suggestions, please open an issue or submit a pull request.

## License

This project is licensed under the MIT License - see the LICENSE.md file for details.
