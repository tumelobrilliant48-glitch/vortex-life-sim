# Unity village prototype instructions

## Scene setup

1. Create a new Unity scene.
2. Add empty GameObject named `GameManager`.
3. Attach `GameManager`.
4. Add empty GameObject named `VillageBuilder`.
5. Attach `VillageBuilder` and call `GenerateVillage()` from `Start()` or via the inspector.
6. Add a `Player` capsule object with tag `Player`.
7. Add `CharacterController`, `PlayerController`, `PlayerNeedsController`.
8. Create UI canvas with text objects for hunger, thirst, hygiene, health, money, and time.
9. Attach `HUDController` and link the text fields.
10. Add `BoxCollider` triggers with `JobMarker`, `ShopMarker`, and `HouseMarker` scripts.
11. Save the scene as `VillagePrototype`.

## Basic playable loop

- Player spawns in village.
- Stats begin to decay over time.
- Player can walk to the job marker and apply for work.
- Player can buy food from the shop.
- Player can use the house to recover and pay rent.
- Day/time updates as the game runs.

## Next milestone

- vehicle system
- public transport
- deeper NPC behavior
- home ownership
- town expansion
