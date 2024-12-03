# Zoo Management System

This is a simple Zoo Management System written in C# that demonstrates object-oriented programming concepts such as inheritance, polymorphism, and encapsulation. It allows you to register various animals in a zoo, display their information, perform actions based on the animal type, and check if an animal is dangerous.

## Features

- **Animal Base Class:** Defines common properties and methods for all animals.
- **Derived Animal Classes:** Includes specific animal behaviors for lions, elephants, and frogs.
- **Zoo Class:** Manages a collection of animals, allowing registration, display, and performing actions.
- **Polymorphism:** Animals can override behaviors such as making sounds, eating, and determining if they are dangerous.
- **Specific Animal Actions:** Each derived animal class has its own specific actions (e.g., lions hunting, elephants lifting weights, frogs needing water).

## How to Run

1. Clone this repository to your local machine:
   ```bash
   git clone https://github.com/Evgeniy20181/Zoo_OOP/
   ```
2. Open the project in your favorite C# development environment (e.g., Visual Studio or Visual Studio Code).
3. Build and run the `Program.cs` file to see the zoo management system in action.

## Code Overview

### Animal Class
This is the base class for all animals. It defines common properties like `Name` and `Species`, and it includes abstract methods that are overridden in the derived classes:
- `LagerHvilkenLyd()`: Returns the sound the animal makes.
- `Spiser()`: Defines the eating behavior of the animal.
- `ErFarlig()`: Returns whether the animal is dangerous.

### Derived Animal Classes
- **Lion**: Represents a lion and includes specific behavior like hunting (`Jager()`).
- **Elephant**: Represents an elephant and includes specific behavior like lifting weight (`KanLofteHvorTungt()`).
- **Frog**: Represents a frog and includes specific behavior like needing water (`TrengerVannIHabitat()`).

### Zoo Class
The `Zoo` class manages a list of animals. It allows you to register animals, display all animals, and execute common actions for all animals:
- `RegistrerDyr(Animal animal)`: Registers an animal in the zoo.
- `VisAlleDyr()`: Displays all animals in the zoo.
- `UtførHandlinger()`: Executes actions for each animal, like making sounds, eating, and checking if they are dangerous.

### Program Class
The `Program` class demonstrates the use of the Zoo management system:
- Creates instances of Lion, Elephant, and Frog.
- Registers these animals in the zoo.
- Displays animal information and performs actions.

## Example Output

```
Dyrene i dyrehagen:
Simba (Lion)
Dumbo (Elephant)
Kermit (Frog)

Dyret: Simba (Lion)
Lyd: Roar!
Simba spiser kjøtt.
Er farlig: Ja

Dyret: Dumbo (Elephant)
Lyd: Trumpet!
Dumbo spiser planter.
Er farlig: Nei

Dyret: Kermit (Frog)
Lyd: Croak!
Kermit spiser insekter.
Er farlig: Nei

Simba er ute på jakt!
Dumbo kan løfte 500 kg!
Kermit trenger vann i sitt habitat.
```

## Contributing

If you'd like to contribute to this project, feel free to fork the repository, make improvements, and submit pull requests. All contributions are welcome!

## License

This project is open-source and available under the [MIT License].

---

Happy coding! 🦁🐘🐸
