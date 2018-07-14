using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLib.Module;

namespace Day7__Tanks_
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Tank[] T34=new Tank[5];
            Tank[] Panther=new Tank[5];
            Tank[] WINNERS = new Tank[5];
            for (int i = 0; i < 5; i++)
            {
                T34[i] = new Tank("T-34", rnd.Next(1, 100), rnd.Next(1, 100), rnd.Next(1, 100));
                Panther[i] = new Tank("Panther", rnd.Next(1, 100), rnd.Next(1, 100), rnd.Next(1, 100));
            }
          
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Round: {0}\n--------", i + 1);
                T34[i].PrintInfo();
                Console.WriteLine("------------------");
                Panther[i].PrintInfo();
                WINNERS[i] = T34[i] * Panther[i];
                Console.WriteLine("\n");
                Console.WriteLine("---------------------------------------");
                Console.Write("| Победитель в {0} раунде танк {1}", i + 1, WINNERS[i].GetTanksName());
                Console.WriteLine("  |");
                Console.WriteLine("---------------------------------------\n\n\n");
            }
        }
    }
}
