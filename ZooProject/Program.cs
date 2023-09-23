using System;

namespace ZooProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Zoo zoo = new Zoo(initialAnimalCount: 5);

            for (int day = 1; day <= 10; day++)
            {
                zoo.SimulateDay();
                zoo.FeedAnimals();
                int aliveCount = zoo.GetAliveAnimalCount();
                Console.WriteLine($"Day {day}: {aliveCount} animals alive.");
            }
        }
    }
}
