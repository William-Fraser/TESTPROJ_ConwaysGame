using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConwaysGameOfLife
{
    class World
    {
        private struct Map 
        {
            public int[,] map { get; set; }

            public Map(int size)
            {
                map = new int[size, size];
            }
        }

        private Map activeWorld;
        private Map newWorld;
        private Map border;

        public World()
        {
            int inputSize = 10; // MN#10: debug, changeto read from input.

            activeWorld = new Map(inputSize);
            newWorld = new Map(inputSize);
            border = new Map(inputSize+2);
        }

        public void CreateBorder()
        { 
            
        }

        public void GenerateLife()
        { 
            
        }

        public void LiveLife()
        { 
        
        }
    }
}
