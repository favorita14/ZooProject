using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooProject.Animals.Elephants
{
    public class Elephant : Animal
    {
        public override string Species => "Elephant";
        public bool CanWalk { get; private set; } = true;

        public override void ReduceHealth(int amount)
        {
            Health = Math.Max(0, Health - amount);
            if (Health < 70)
                CanWalk = false;
        }

        public override bool IsAlive()
        {
            return (Health > 0) && (Health >= 70 || CanWalk);
        }
    }
}
