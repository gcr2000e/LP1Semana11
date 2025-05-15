```mermaid
classDiagram
    class Player {
        +string Name
        +int Score
        +void UpdateScore(int)
    }

    class PlayerManager {
        +List~Player~ Players
        +void AddPlayer(Player)
        +void RemovePlayer(Player)
        +Player FindPlayer(string)
    }

    class PlayerController {
        +PlayerManager manager
        +void AddNewPlayer(string)
        +void UpdatePlayerScore(string, int)
    }

    PlayerManager "1" o-- "*" Player
    PlayerController "1" --> "1" PlayerManager