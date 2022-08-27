using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConwaysGameOfLife
{
    public class LifeGenerator
    {
        private Random random = new Random(); // class level variable used, to not lose random rate

        public Life CreateLife(int worldSize, int chanceOfLife)
        {
            Life life = new Life();

            if (LifeCreated(worldSize, chanceOfLife))
            {
                life.Live(); // life is made
            }

            return life;
        }

        private bool LifeCreated(int worldSize, int chanceOfLife)
        {
            int chance = random.Next(0, 10);
            return chanceOfLife > chance; // if the cOL is greater than c, life is created
        }
    }
}
