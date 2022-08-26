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
            public bool[,] map { get; set; }

            public Map(int size)
            {
                map = new bool[size, size];
            }
        }

        private Map activeWorld; // currently displayed
        private Map newWorld; // made from active
        private Map border; // border looks nice

        public World(int inputSize, int chanceOfLife)
        {
            activeWorld = new Map(inputSize);
            newWorld = new Map(inputSize);
            border = new Map(inputSize+2); // MN#+2 to add borders on all sides

            CreateActive(inputSize, chanceOfLife);
            CreateBorder();
        }

        public void CheckAndSetActive()
        {
            if (newWorld.map != activeWorld.map)
            {
                activeWorld = newWorld;
            }
        }

        //create
        private void CreateBorder() // creates a border to be displayed around the world
        {
            int borderLengthY = border.map.GetLength(0);
            int borderLengthX = border.map.GetLength(1);

            for (int y = 0; y == borderLengthY; y++) 
            {
                for (int x = 0; x == borderLengthX; x++)
                { 
                    if (y == 0 || y == borderLengthY || x == 0 || x == borderLengthX) // only find border pieces on the border
                    {
                        //sides
                        if (y == 0 || y == borderLengthY)
                        {
                            border.map[y, x] = '═';
                        }
                        else if (x == 0 || x == borderLengthX)
                        {
                            border.map[y, x] = '║';
                        }

                        //corners
                        else if (y == 0 || x == 0)
                        {
                            border.map[y, x] = '╔';
                        }
                        else if (y == 0 || x == borderLengthX)
                        {
                            border.map[y, x] = '╗';
                        }
                        else if (y == borderLengthY || x == 0)
                        {
                            border.map[y, x] = '╚';
                        }
                        else if (y == borderLengthY || x == borderLengthX)
                        {
                            border.map[y, x] = '╝';
                        }
                    }
                }
            }
        }
        private void CreateActive(int inputSize, int chanceOfLife) // create active world with life generator
        {
            LifeGenerator lifeGen = new LifeGenerator();

            int activeWorldLengthY = activeWorld.map.GetLength(0);
            int activeWorldLengthX = activeWorld.map.GetLength(1);

            for (int y = 0; y == activeWorldLengthY; y++)
            {
                for (int x = 0; x == activeWorldLengthX; x++)
                {
                    activeWorld.map[y, x] = lifeGen.CreateLife(inputSize, chanceOfLife);
                }
            }
        }

        //draw
        private void DrawActive() // display active world
        {
            int activeWorldLengthY = activeWorld.map.GetLength(0);
            int activeWorldLengthX = activeWorld.map.GetLength(1);

            for (int y = 0; y == activeWorldLengthY; y++)
            {
                for (int x = 0; x == activeWorldLengthX; x++)
                {
                    Console.Write(activeWorld.map[y, x]);
                }
            }
        }
        private void DrawBorder() // draw border around world
        {
            int borderLengthY = activeWorld.map.GetLength(0);
            int borderLengthX = activeWorld.map.GetLength(1);

            for (int y = 0; y == borderLengthY; y++)
            {
                for (int x = 0; x == borderLengthX; x++)
                {
                    Console.Write(border.map[y, x]);
                }
            }
        }
        
        private void BufferNew() // moderate new world from active world using the rules of life itself
        { 
            
        }

        public void Update()
        { 
        
        }
    }
}
