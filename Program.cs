using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Working with LINQ & Generic collections");
            //Create a list<t>--->THIS IS YOUR DATASET NOW
            List <Car> myCars = new List<Car>() 
            { 
                
                new Car {Name="Beast", Color="Black", Speed=180, Make="Merc"}, //Helpful for module info collection in POE----> IT IS MUCH FASTER
                new Car {Name="Clone", Color="Pink", Speed=180, Make="Renault"},
                new Car {Name="Bee", Color="Yellow", Speed=280, Make="BMW"},
                new Car {Name="A5", Color="Red", Speed=380, Make="Audi"},
                new Car {Name="Mikey", Color="Silve", Speed=150, Make="Porche"}

               
            };


            displayAll(myCars);
            Console.WriteLine();
            countItems(myCars);
            Console.WriteLine();
            slowCars(myCars);
            Console.WriteLine();
            fastCars(myCars);
            Console.WriteLine();
            descOrder(myCars);
            Console.WriteLine();
            makeDesc(myCars);
            Console.ReadLine();
        }//Main ends
        //CREATE A METHOD --->DISPLAY ALL
        static void displayAll(List<Car> cars) 
        {
            Console.WriteLine("Car details>>>>");
            foreach (var car in cars) 
            {
                Console.WriteLine($"Name: {car.Name}");
                Console.WriteLine($"Color: {car.Color}");
                Console.WriteLine($"Speed: {car.Speed}");
                Console.WriteLine($"Make: {car.Make}");
                Console.WriteLine($"--------------------------");
            }

        }

        //Method to count all items in the list
        static void countItems(List<Car> cars) 
        {
            var counts = cars.Count;
            Console.WriteLine($"Total number of cars are: {counts}");
        }
        //Method using LINQ to find all cars going < 100km/hr
        static void slowCars(List<Car> cars) 
        {
            var slow = from c in cars
                       where c.Speed < 100
                       select c;
            //Add an if else to handle items not found
            if (slow.Any())
                //output
                foreach (var car in slow)
                {
                    Console.WriteLine($"The car called {car.Name} is going < 100km/hr");
                }
            else 
            {
                Console.WriteLine("No car found");
            }
        }

        //Create a method using LINQ---> Finds all cars > 180km/hr
        static void fastCars(List<Car> cars)
        {
            var fast = from c in cars
                       where c.Speed > 180
                       select c;
            //Add an if else to handle items not found
            if (fast.Any())
                //output
                foreach (var car in fast)
                {
                    Console.WriteLine($"The car called {car.Name} is going > 180km/hr");
                }
            else
            {
                Console.WriteLine("No car found");
            }

        }

        //Print out the car names in descending order using LINQ in a method
        static void descOrder(List<Car> cars) 
        { 
            var carsDesc = from c in cars
                           orderby c.Name descending
                           select c;
            Console.WriteLine("Cars in desc order");
            foreach (var car in carsDesc) 
            {
                Console.WriteLine("------------------");
                Console.WriteLine($"Name: {car.Name}");
                Console.WriteLine("------------------");

            }
        }

        //hw----> Create a method to print the car makes in ascending order
    }//Class ends

    #region Car Class objects
    public class Car
    {
        //Objects
        public string Name { get; set; }
        public string Color { get; set; }
        public int Speed { get; set; }
        public string Make { get; set; }
    }
    #endregion
}
