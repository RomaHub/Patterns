using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Creator fm = new FighterCreator();
            Character fighter = fm.Create();

            fm = new HunterCreator();
            Character hunter = fm.Create();

            Console.ReadLine();

        }
    }
}
