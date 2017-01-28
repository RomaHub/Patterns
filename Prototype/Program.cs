using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Prototype clone = new Character(10, 2);
            ((Character)clone).TakeDamage(5);

            Prototype clone2 = clone.Clone();
            ((Character)clone2).TakeDamage(2);

            ((Character)clone).GetCurrentHP();
            ((Character)clone2).GetCurrentHP();

            //IClonable

            Enemy enemy = new Enemy(10);
            Enemy enemy2 = (Enemy)enemy.Clone();
            enemy.currentHP -= 2;
            Console.WriteLine("enemy hp{0}", enemy.currentHP.ToString());
            Console.WriteLine("enemy clone hp{0}", enemy2.currentHP.ToString());


            Console.ReadLine();
        }
    }
}
