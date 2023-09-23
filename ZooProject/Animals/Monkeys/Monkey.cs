using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooProject.Animals.Monkeys
{
    public class Monkey : Animal
    {
        public override string Species => "Monkey";

        public override bool IsAlive()
        {
            return Health >= 30;
        }
    }
}
