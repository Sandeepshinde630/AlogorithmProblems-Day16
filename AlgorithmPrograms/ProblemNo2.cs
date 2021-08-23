using System;
using System.Collections;
using System.Text;

namespace AlgorithmPrograms
{
    class ProblemNo2
    {
        public void runNo2()
        {
            string[] cars = { "BMW", "Mercedes", "Jaguar", "Audi", "Lamborgini", "RangeRover", "Discovery" };

            Array.Sort(cars);
            foreach (var item in cars)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Please enter the car you want to search for:");

            string searchCars = Console.ReadLine();

            int i = Array.BinarySearch(cars, searchCars);

            if (i >= 0)
                Console.WriteLine("Car found at position " + i + "\n");
            else
                Console.WriteLine("Car not found\n");

            Console.WriteLine("press any key to close\n");

            Console.ReadKey();
        

        
    }
    }
}
