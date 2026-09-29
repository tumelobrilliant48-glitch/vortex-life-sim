# Phase 1 Playable Village Prototype

This phase focuses on building the first believable game loop:

- Character in a village
- Need bars: hunger, thirst, health, hygiene, fitness, happiness
- NPCs with simple jobs and daily routines
- Basic money and salary system
- Basic interactions: food, work, rest, hygiene
- Save system and time cycle

## Goal
A player can wake up, eat, work, travel, spend money, rest, and recover in a simple village environment. This is the foundation that later expands into cities, countries, space, and world simulation.

## What is included

- `PlayerNeedsController` — handles decay and recovery
- `JobSystem` — assigns jobs and manages income
- `EconomyManager` — handles debt, purchases, and wages
- `NPCScheduleController` — gives NPCs simple daily tasks
- `InteractableObject` — supports E-key object interactions
- `TimeCycle` — manages day and night progression
- `SaveSystem` — stores player progression locally

## MVP flow

1. Character spawns into village
2. Needs begin to decay over time
3. NPCs begin doing jobs and daily tasks
4. Player can get a job and earn money
5. Player can buy basic items and recover needs
6. Save data persists

## Next stage

After this, the next major expansion will be:
- more neighborhoods
- public transport
- houses and building system
- police and crime system
- family and relationships
- country-level economy
