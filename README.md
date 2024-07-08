# Adventure Quest RPG

## Overview
Adventure Quest RPG is a console-based role-playing game where players explore different locations, battle monsters, and collect items. The game features a variety of monsters, including powerful boss monsters, and allows players to manage their inventory and equip items to enhance their abilities.

## Features
- **Player and Monster Battles**: Engage in turn-based combat with various monsters.
- **Boss Monsters**: Face challenging boss monsters with high stats.
- **Inventory System**: Collect and manage items like weapons, armor, and potions.
- **Exploration**: Discover new locations and choose your actions.
- **Random Encounters**: Encounter different types of monsters randomly.

## Battle Mechanics

### Attributes
- **Name**: The name of the character or monster.
- **Health**: Represents the current health points. When it reaches zero, the character or monster is defeated.
- **AttackPower**: Determines the amount of damage dealt to an opponent.
- **Defense**: Reduces the damage received from an opponent’s attack.

### Battle Process
1. **Initiation**: A battle begins when the player encounters a monster.
2. **Turns**: Battles are turn-based. The player and the monster take turns to attack each other.
3. **Attack Calculation**: 
   - The damage dealt during an attack is calculated as: `Damage = AttackPower - Defense`.
   - If `Defense` is greater than or equal to `AttackPower`, the minimum damage dealt is 1.
4. **Health Reduction**: The calculated damage is subtracted from the defender's `Health`.
5. **Defeat**: If a character or monster's `Health` reaches zero, they are defeated.

## Game Structure

### Files and Classes
- **IBattleStates.cs**: Defines the `IBattleStates` interface with properties `Name`, `Health`, `AttackPower`, and `Defense`.
- **Player.cs**: Implements the `IBattleStates` interface and contains player-specific attributes and methods.
- **Monster.cs**: Implements the `IBattleStates` interface and contains monster-specific attributes and methods.
- **BossMonster.cs**: Inherits from `Monster` with enhanced stats for a greater challenge.
- **BattleSystem.cs**: Manages the battle logic and processes attacks between entities implementing `IBattleStates`.
- **Adventure.cs**: Manages the game loop, player actions, location exploration, and random monster encounters.
- **Inventory.cs**: Manages the collection of items, including methods to add items and display inventory contents.
- **Items.cs**: Defines the base `Item` class and derived classes `Weapon`, `Armor`, and `Potion`.
- **Program.cs**: The main entry point of the application.

### Gameplay
1. **Starting the Game**: The game initializes with the player and a list of monsters.
2. **Exploring Locations**: The player can move between different locations like forests, caves, and towns.
3. **Encountering Monsters**: The player may encounter monsters randomly in different locations.
4. **Battling Monsters**: Engage in turn-based combat with monsters. Use the `Attack` method to deal damage.
5. **Managing Inventory**: After defeating monsters, collect items and manage them in the inventory. Equip weapons and armor or use potions to enhance abilities.
6. **Game Over**: The game ends when the player chooses to end the game or if the player's health reaches zero.

### Additional Features
- **Random Item Drops**: After defeating a monster, there is a small chance it will drop items like weapons, armor, or potions.
- **Inventory Usage**: Before encountering any monster, the player can view and use items from the inventory.

## Testing
- **XUnit Tests**: The game includes tests for scenarios such as finding and encountering a boss monster and moving to new locations correctly.

---

### How to Run the Game
1. Clone the repository.
2. Open the solution in your preferred IDE.
3. Build the solution to restore dependencies and compile the code.
4. Run the application from the `Program.cs` file.

Enjoy your adventure in the Adventure Quest RPG!
