using System;

namespace Movable
{
    // Interface IMovable
    public interface IMovable
    {
        void Move();
    }

    // Class Car that implements IMovable
    public class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }

    // Class Bicycle that implements IMovable
    public class Bicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }
} 