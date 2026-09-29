# VORTEX Life Sim

A scalable life-simulation game foundation for a multiplayer, persistent open-world game inspired by GTA-style living, NPC simulation, economy, family systems, and world expansion.

This repository is the technical foundation for the project. It is intentionally structured for future expansion from a small village prototype to towns, cities, countries, planets, and alien systems.

## Project vision

VORTEX Life Sim is a persistent life simulation where players:
- create a character
- start in a village
- eat, sleep, work, drive, socialize, and build a life
- earn money, own property, and build businesses
- interact with NPCs with jobs, families, relationships, and daily routines
- expand into cities, countries, and eventually space

## Current phase

Phase 1: Foundation and MVP architecture
- Character creator
- Basic player movement
- Player stats: hunger, thirst, health, hygiene, happiness, fitness
- NPC AI loop
- Time/day cycle
- Money and inventory system
- Save and cloud-save structure
- Backend login and player data model
- Roadmap for full expansion

## Repository structure

- `Assets/Scripts/Core` — core gameplay systems
- `Assets/Scripts/AI` — NPC behavior and scheduling
- `Assets/Scripts/World` — world/time systems
- `Assets/Scripts/Services` — save, cloud, and API services
- `docs/` — game design and technical docs
- `README.md` — startup overview
- `.gitignore` — Unity project config

## Recommended engine

- Engine: Unity 2022 LTS
- Language: C#
- Backend: Firebase / PlayFab / custom Node.js API
- Database: Firestore / PostgreSQL
- Storage: Firebase Storage / AWS S3
- Auth: Google login, phone login, email/password

## Suggested MVP goals

Before adding countries and planets, the game should first support:
1. Character creation
2. Walking and basic interaction
3. Eat / drink / sleep / bath / hygiene
4. Daily schedule for NPCs
5. A working economy with salary and spending
6. Small village with a few buildings
7. Basic cars and driving
8. Save system and login support
9. Data models for future world expansion

## Quick start

1. Open this repository in GitHub.
2. Create a Unity project from the same folder structure or adapt these scripts into your own Unity project.
3. Follow the docs in `docs/`.
4. Use the base scripts as the beginning of the prototype.

## Important note

This repo is intentionally modular and designed to scale. The largest mistakes in a game like this are:
- building the whole world too early
- adding 100k features before the core loop works
- missing data models before content

The correct approach is to build the first believable life loop and expand carefully.

## Core product roadmap

- Phase 1: Village life sim
- Phase 2: Town and city economy
- Phase 3: Country and political systems
- Phase 4: Space travel and planets
- Phase 5: Massive multiplayer and monetization

## License

This project is intended as a foundation for your own commercial or personal game. Add your own licensing and legal protection before shipping publicly.
