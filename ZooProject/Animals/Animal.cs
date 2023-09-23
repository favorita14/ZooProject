using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooProject.Animals
{
    public abstract class Animal : IAnimal
    {
        public abstract string Species { get; }
        public int Health { get; set; } = 100;

        public virtual void ReduceHealth(int amount)
        {
            Health = Math.Max(0, Health - amount);
        }

        public abstract bool IsAlive();
    }
}
