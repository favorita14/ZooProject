using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooProject.Animals;

namespace ZooProject.FeedingStrategies
{
    public interface IFeedingStrategy
    {
        void Feed(IAnimal animal);
    }
}
