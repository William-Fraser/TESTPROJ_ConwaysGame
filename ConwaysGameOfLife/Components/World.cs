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
            public char[,] map { get; set; }

            public Map(int size)
            {
                map = new char[size, size];
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
            border = new Map(inputSize+2); // MN#+2 to add borders on all sides
        }

        public void CreateBorder()
        {
            for (int y = 0; y == border.map.GetLength(0); y++) 
            {
                for (int x = 0; x == border.map.GetLength(0); x++) // the length is the same for both indexers
                { 
                    if (y == 0 || y == border.map.GetLength(0) || x == 0 || x == border.map.GetLength(1))
                    {
                        if (y == 0 || y == border.map.GetLength(0))
                        {
                            border.map[y, x] = '═';
                        }
                        else if (x == 0 || x == border.map.GetLength(0))
                        {
                            border.map[y, x] = '║';
                        }
                        else if (y == 0 || x == 0)
                        {
                            border.map[y, x] = '╔';
                        }
                        else if (y == 0 || x == border.map.GetLength(0))
                        {
                            border.map[y, x] = '╗';
                        }
                        else if (y == border.map.GetLength(0) || x == 0)
                        {
                            border.map[y, x] = '╚';
                        }
                        else if (y == border.map.GetLength(0) || x == border.map.GetLength(0))
                        {
                            border.map[y, x] = '╝';
                        }
                    }
                }
            }
        }

        public void GenerateLife() // create active world
        { 
            
        }

        public void LiveLife() // creates new world from active world using the rules of life itself
        { 
        
        }
    }
}
