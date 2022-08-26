using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConwaysGameOfLife
{
    class Program
    {
        //private fields
        private LifeGenerator lifeGenerator;

        static void Main(string[] args)
        {

            Console.WriteLine("Programed by William Fraser.");
            
            //Console.WriteLine("Instructions \n ... "); << user input rules // how to play
            
            Console.WriteLine("\n\nPress any key to begin Conways Game Of Life.");

            Console.ReadKey(true);



            Console.ReadKey();
            Console.Clear();

        }
    }
}
