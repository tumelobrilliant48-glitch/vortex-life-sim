# Backend and database foundation

## 1. Core data requirements

The backend should support:
- account auth
- cloud save
- progression data
- world state
- NPC simulation state
- company and property ownership
- transactions and reputations
- future multiplayer support

## 2. Recommended backend stack

### Option A: Firebase-first approach
- Firebase Auth
- Firestore
- Firebase Storage
- Firebase Cloud Messaging
- Firebase Analytics

### Option B: Custom server approach
- Node.js or C# API
- PostgreSQL database
- Redis cache
- cloud storage for assets and DLC

## 3. Main collections / tables

### users
- id
- displayName
- email
- phone
- createdAt
- lastLogin
- country
- money
- level
- age
- gender
- premiumStatus

### player_stats
- userId
- hunger
- thirst
- hygiene
- happiness
- health
- fitness
- stamina
- energy

### characters
- id
- userId
- name
- skinColor
- hairStyle
- faceShape
- clothes
- bodyType
- gender
- birthDay
- currentLocation

### npcs
- id
- name
- age
- gender
- jobId
- homeId
- currentLocation
- relationshipStatus
- mood
- scheduleState
- energy
- hunger
- health

### jobs
- id
- title
- jobType
- salary
- requiredSkills
- locationId
- employerId
- workingHours

### houses
- id
- ownerId
- address
- type
- buildProgress
- buildDaysLeft
- rooms
- cost
- locked

### vehicles
- id
- ownerId
- modelName
- brand
- fuel
- health
- parts
- modifications
- location
- isStolen

### companies
- id
- ownerId
- name
- type
- revenue
- employees
- location

### world_locations
- id
- name
- type
- country
- region
- x
- y
- z

### transactions
- id
- userId
- type
- amount
- source
- timestamp

### events
- id
- type
- message
- targetUserId
- relatedNpcId
- timestamp

## 4. Cloud save system

The save system should update in two ways:
- local save every few minutes
- cloud sync after login and after key events

Important save events:
- character creation
- money changes
- work start/end
- house purchase or build progress
- vehicle buy/repair
- marriage or family changes
- mission goal progression

## 5. Security

Protect against:
- money cheat injection
- forged ownership claims
- fake vehicle state updates
- anti-cheat bypass requests

Use:
- server-side validation
- transaction logging
- signed player actions
- anti-cheat checks for premium features

## 6. Multiplayer preparation

The backend should be ready for:
- player avatars in shared world
- public chat
- trading and property selling
- server-authoritative world state
- region-based hosting

## 7. MVP backend suggestions

For a first version, keep it simple:
- Firebase Auth
- Firestore database
- Cloud Save
- Remote Config
- Analytics
- Event logging

This is enough to support a village MVP while still scaling later.
