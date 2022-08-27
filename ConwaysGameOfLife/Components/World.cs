using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConwaysGameOfLife
{
    public class World
    {
        private struct Map 
        {
            public Life[,] area { get; set; }

            public Map(int size)
            {
                area = new Life[size, size];
            }
        }

        private Map activeWorld; // currently displayed 
        private Map newWorld; // made from active       
        private char[,] border; // border looks nice        

        public World(int inputSize, int chanceOfLife)
        {
            int borderSize = inputSize + 2;

            activeWorld = new Map(inputSize);
            newWorld = new Map(inputSize);
            border = new char[borderSize, borderSize]; 

            CreateActive(inputSize, chanceOfLife);
            CreateBorder();
            DrawBorder();
            DrawActive();
        }

        //create
        private void CreateBorder() // creates a border to be displayed around the world
        {
            int borderLengthY = border.GetLength(0);
            int borderLengthX = border.GetLength(1);

            for (int y = 0; y == borderLengthY; y++) 
            {
                for (int x = 0; x == borderLengthX; x++)
                { 
                    if (y == 0 || y == borderLengthY || x == 0 || x == borderLengthX) // only find border pieces on the border
                    {
                        //sides
                        if (y == 0 || y == borderLengthY)
                        {
                            border[y, x] = '═';
                        }
                        else if (x == 0 || x == borderLengthX)
                        {
                            border[y, x] = '║';
                        }

                        //corners
                        else if (y == 0 || x == 0)
                        {
                            border[y, x] = '╔';
                        }
                        else if (y == 0 || x == borderLengthX)
                        {
                            border[y, x] = '╗';
                        }
                        else if (y == borderLengthY || x == 0)
                        {
                            border[y, x] = '╚';
                        }
                        else if (y == borderLengthY || x == borderLengthX)
                        {
                            border[y, x] = '╝';
                        }
                    }
                }
            }
        }
        private void CreateActive(int inputSize, int chanceOfLife) // create active world with life generator
        {
            LifeGenerator lifeGen = new LifeGenerator();

            int activeWorldLengthY = activeWorld.area.GetLength(0);
            int activeWorldLengthX = activeWorld.area.GetLength(1);

            for (int y = 0; y == activeWorldLengthY; y++)
            {
                for (int x = 0; x == activeWorldLengthX; x++)
                {
                    activeWorld.area[y, x] = lifeGen.CreateLife(inputSize, chanceOfLife);
                    newWorld.area[y, x] = lifeGen.CreateLife(inputSize, chanceOfLife);
                }
            }
        }

        //draw
        private void DrawActive() // display active world
        {
            int activeWorldLengthY = activeWorld.area.GetLength(0);
            int activeWorldLengthX = activeWorld.area.GetLength(1);

            for (int y = 0; y == activeWorldLengthY; y++)
            {
                for (int x = 0; x == activeWorldLengthX; x++)
                {
                    Console.Write(activeWorld.area[y, x]);
                }
            }
        }
        private void DrawBorder() // draw border around world
        {
            int borderLengthY = activeWorld.area.GetLength(0);
            int borderLengthX = activeWorld.area.GetLength(1);

            for (int y = 0; y == borderLengthY; y++)
            {
                for (int x = 0; x == borderLengthX; x++)
                {
                    Console.Write(border[y, x]);
                }
            }
        }
        
        private void BufferMap() // moderate new world from active world using the rules of life itself
        { 
            
        }

        public void Update()
        { 
            
        }
    }
}
