using System;

namespace OOPGit_PrcaticeVehicle
{
    public class Vehicle
    {
        private int _capacity;
        private int _numPassengers;
        private int _speed = 10;

        public int NumPassengers { get; set; }
        public int Position { get; set; }

        public Vehicle() { }

        public Vehicle(int capacity,int speed = 10) 
        {
            _capacity = capacity;
            _speed = speed;
        
        }

        public string Move()
        {
            Position += _speed;
            return $"Moving along";
        }

        public string Move(int times)
        {
            Position += times * _speed;
            return $"Moving along {times} times";
        }


        static void Main(string[] args)
        {
        }
    }
}
