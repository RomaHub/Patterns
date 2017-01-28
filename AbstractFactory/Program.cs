using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero archer = new Hero(new ElfCreator());

            archer.Hit();
            archer.Run();

            Hero warrior = new Hero(new HumanCreator());

            warrior.Hit();
            warrior.Run();

            Console.ReadLine();
        }
    }
}
