using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooProject.Animals.Giraffes
{
    public class Giraffe : Animal
    {
        public override string Species => "Giraffe";

        public override bool IsAlive()
        {
            return Health >= 50;
        }
    }
}
