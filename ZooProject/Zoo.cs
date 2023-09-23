using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooProject.FeedingStrategies;
using ZooProject.FeedingStrategies.Elephants;
using ZooProject.FeedingStrategies.Giraffes;
using ZooProject.FeedingStrategies.Monkeys;
using ZooProject.Animals;
using ZooProject.Animals.Monkeys;
using ZooProject.Animals.Giraffes;
using ZooProject.Animals.Elephants;

namespace ZooProject
{
    public class Zoo
    {
        private List<IAnimal> animals = new List<IAnimal>();
        private Dictionary<string, IFeedingStrategy> feedingStrategies = new Dictionary<string, IFeedingStrategy>();

        public Zoo(int initialAnimalCount)
        {
            for (int i = 0; i < initialAnimalCount; i++)
            {
                animals.Add(new Monkey());
                animals.Add(new Giraffe());
                animals.Add(new Elephant());
            }

            feedingStrategies.Add("Monkey", new MonkeyFeedingStrategy());
            feedingStrategies.Add("Giraffe", new GiraffeFeedingStrategy());
            feedingStrategies.Add("Elephant", new ElephantFeedingStrategy());
        }

        public void SimulateDay()
        {
            Random random = new Random();

            foreach (var animal in animals)
            {
                int damage = random.Next(0, 21);
                animal.ReduceHealth(damage);
            }
        }

        public void FeedAnimals()
        {
            foreach (var animal in animals)
            {
                feedingStrategies[animal.Species].Feed(animal);
            }
        }

        public int GetAliveAnimalCount()
        {
            return animals.Count(animal => animal.IsAlive());
        }
    }
}
