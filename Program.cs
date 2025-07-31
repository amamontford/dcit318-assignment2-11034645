using System;
using AnimalSounds;
using Shapes;
using Movable;

namespace ConsoleApplications
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Object Oriented Programming in C#");
                Console.WriteLine("1. Animal Sounds Demo");
                Console.WriteLine("2. Shapes Area Calculator");
                Console.WriteLine("3. Movable Interface Demo");
                Console.WriteLine("4. Exit");
                Console.Write("\nSelect an application (1-4): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        RunAnimalSoundsDemo();
                        break;
                    case "2":
                        RunShapesAreaCalculator();
                        break;
                    case "3":
                        RunMovableDemo();
                        break;
                    case "4":
                        Console.WriteLine("Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Press any key to continue...");
                        Console.ReadKey();
                        break;
                }
            }
        }

        static void RunAnimalSoundsDemo()
        {
            Console.Clear();
            Console.WriteLine("Animal Sounds Demo \n");

            // Create instances of Animal, Dog, and Cat
            Animal animal = new Animal();
            Dog dog = new Dog();
            Cat cat = new Cat();

            // Call the MakeSound() method on each instance
            Console.WriteLine("Animal sound:");
            animal.MakeSound();

            Console.WriteLine("\nDog sound:");
            dog.MakeSound();

            Console.WriteLine("\nCat sound:");
            cat.MakeSound();

            // Demonstrate polymorphism
            Console.WriteLine("\n Polymorphism Example");
            Animal[] animals = { animal, dog, cat };
            
            for (int i = 0; i < animals.Length; i++)
            {
                Console.Write($"Animal {i + 1} sound: ");
                animals[i].MakeSound();
            }

            Console.WriteLine("\nPress any key to return to menu...");
            Console.ReadKey();
        }

        static void RunShapesAreaCalculator()
        {
            Console.Clear();
            Console.WriteLine(" Shapes Area Calculator \n");

            // Create instances of Circle and Rectangle
            Circle circle = new Circle(5.0);
            Rectangle rectangle = new Rectangle(4.0, 6.0);

            // Display their areas
            Console.WriteLine($"Circle with radius {circle.Radius}:");
            Console.WriteLine($"Area = π × r² = π × {circle.Radius}² = {circle.GetArea():F2} square units");

            Console.WriteLine($"\nRectangle with length {rectangle.Length} and width {rectangle.Width}:");
            Console.WriteLine($"Area = length × width = {rectangle.Length} × {rectangle.Width} = {rectangle.GetArea():F2} square units");

            // Demonstrate polymorphism with abstract class
            Console.WriteLine("\n Polymorphism with Abstract Class ");
            Shape[] shapes = { circle, rectangle };
            
            for (int i = 0; i < shapes.Length; i++)
            {
                Console.WriteLine($"Shape {i + 1} area: {shapes[i].GetArea():F2} square units");
            }

            Console.WriteLine("\nPress any key to return to menu...");
            Console.ReadKey();
        }

        static void RunMovableDemo()
        {
            Console.Clear();
            Console.WriteLine(" Movable Interface Demo \n");

            // Create instances of Car and Bicycle
            Car car = new Car();
            Bicycle bicycle = new Bicycle();

            // Call the Move() method on each instance
            Console.WriteLine("Car movement:");
            car.Move();

            Console.WriteLine("\nBicycle movement:");
            bicycle.Move();

            // Demonstrate polymorphism with interface
            Console.WriteLine("\n Polymorphism with Interface ");
            IMovable[] movables = { car, bicycle };
            
            for (int i = 0; i < movables.Length; i++)
            {
                Console.Write($"Movable object {i + 1}: ");
                movables[i].Move();
            }

            Console.WriteLine("\nPress any key to return to menu...");
            Console.ReadKey();
        }
    }
} 