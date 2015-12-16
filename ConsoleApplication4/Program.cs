using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] ajedrez =  new string[8,8] {
            {"T","C","A","R","RE","A","C","T"},
            {"P","P","P","P","P","P","P","P"},
            {"0","0","0","0","0","0","0","0"},
            {"0","0","0","0","0","0","0","0"},
            {"0","0","0","0","0","0","0","0"},
            {"0","0","0","0","0","0","0","0"},
            {"P","P","P","P","P","P","P","P"},
            {"T","C","A","RE","R","A","C","T"}
        };
            //Esto es para mover el peon para el frente

            ajedrez[2, 4] = ajedrez[1, 4];
            ajedrez[1, 4] = "0";

            for(int i = 0;i < 8; i++)
            {
                for (int index = 0; index < 8; index++)
                {
                    Console.Write("{0} ", ajedrez[i, index]);
                }
                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }
    }
}
