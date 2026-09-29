# VORTEX Life Sim architecture

## 1. Core design goal

The game must be modular and easy to expand. The world should not be built as one giant monolith. Instead, it should be built as a set of game systems that interact with each other.

## 2. Recommended architecture layers

### A. Presentation Layer
- UI panels
- Character creator screen
- Inventory screen
- Phone app screen
- Map/ GPS screen
- HUD
- Vehicle UI
- Pause/settings menu

### B. Game Logic Layer
- Movement controller
- Economy manager
- Job system
- NPC scheduler
- World time and event manager
- House/building manager
- Vehicle manager
- Social relationship system

### C. Simulation Layer
- NPC daily routines
- Weather and season system
- Age progression
- Family tree and inheritance
- Crime and police systems
- Company ownership
- Land acquisition and house construction

### D. Data Layer
- Player save data
- NPC states
- World state
- Jobs and salaries
- Company ownership
- Cars and houses
- Relationships
- Transactions and logs

### E. Service Layer
- Firebase auth
- Firestore save data
- Cloud backup
- Analytics
- Push notifications
- Anti-cheat checks

## 3. Game loop

The first prototype should not try to include every system. The player should be able to do a real loop:

1. Create character
2. Start in village
3. Sleep / wake up
4. Eat and clean up
5. Travel to work
6. Earn money
7. Buy food, car fuel, clothes, or rent
8. Build relationships
9. Save progress

This is the foundation that later grows into city, country, and space simulation.

## 4. Recommended technical stack

### Game engine
- Unity 2022 LTS
- C# scripts

### Game data
- Firestore (for player and world state)
- Local save file for offline gameplay
- Rich object structure for NPCs, homes, vehicles, and inventory

### Analytics and live ops
- Firebase Analytics
- Crashlytics
- Remote Config

### Monetization
- Google Play Billing
- Apple Store billing
- Premium upgrade purchase flow
- Optional cosmetic or time-skip systems

## 5. MVP systems to build first

- Character creator
- Stats: hunger, thirst, happiness, hygiene, health, fitness
- Basic walking and interacting
- Basic NPC routines
- Money flow and salary
- A simple village scene
- A functional car or vehicle prototype
- Save/load system
- Phone app UI shell
- Marriage / family foundation

## 6. Scalability rules

- Use modular classes, not giant scripts
- Use data-driven design for jobs, vehicles, homes, and shops
- Keep world generation lazy-loaded
- Avoid loading all countries or planets at once
- Use LOD and NPC pooling for performance
- Separate simulation state from UI state

## 7. Future expansion path

### Phase 1
Village and lifestyle simulation

### Phase 2
Town and city economy

### Phase 3
Country politics and jobs

### Phase 4
Airport, flights, space travel

### Phase 5
Alien worlds and interplanetary systems

## 8. Rule to remember

A world becomes believable when the player can perform a basic daily life loop well. Then the world expands around that loop.
