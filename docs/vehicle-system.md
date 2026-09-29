# Vehicle system foundation

## Goal
The next step after the village life-sim is a simple drivable vehicle system that supports:
- vehicle movement
- fuel consumption
- ownership tracking
- basic refueling
- spawn in the world

## Included features

- `VehicleController` for acceleration, turning, braking, and fuel usage
- `VehicleOwnership` for owner and theft state
- `FuelStation` for refueling the current vehicle
- `VehicleSpawner` for spawning a vehicle in the world

## Unity setup

1. Create a simple car model with a `Cube` body and `Sphere` wheels, or use a placeholder.
2. Add a `Rigidbody` component.
3. Add `VehicleController`.
4. Add `VehicleOwnership`.
5. Place the car in the village or road area.
6. Add a trigger object with `FuelStation` script for refueling.
7. Tag the player as `Player`.

## Next layer after vehicles

- vehicle damage and repair
- doors, windows, trunk, hood interactions
- driving school and licenses
- town transport logic
- NPC vehicle traffic
- vehicle modification system
