using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConwaysGameOfLife
{
    public class LifeGenerator
    {
        Random random = new Random(); // class used for deciding generation

        public bool CreateLife(int worldSize, int chanceOfLife)
        {
            bool life = false; // life starts as nothing;

            if (LifeCreated(worldSize, chanceOfLife))
            {
                life = true; // life is made
            }

            return life;
        }

        private bool LifeCreated(int worldSize, int chanceOfLife)
        {
            int chance = random.Next(0, worldSize);
            return chanceOfLife > chance; // if the cOL is greater than c, life is within chance and is created
        }
    }
}
