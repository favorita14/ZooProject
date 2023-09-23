using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooProject.Animals;

namespace ZooProject.FeedingStrategies.Giraffes
{
    public class GiraffeFeedingStrategy : IFeedingStrategy
    {
        public void Feed(IAnimal animal)
        {
            int foodAmount = new Random().Next(10, 26);
            animal.Health = Math.Min(100, animal.Health + foodAmount);
        }
    }
}
