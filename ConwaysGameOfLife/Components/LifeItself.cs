using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConwaysGameOfLife
{
    public class Life
    {
        private bool alive;
        private char avatar;
        private Life[,] neighbours;
        
        public void Live()
        {
            alive = true;
            avatar = '█';
        }

        public void Die()
        {
            alive = false;
            avatar = ' ';
        }

        public Life Exist()
        {
            Life life = this;

            return life;
        }

        public void 
    }
}
