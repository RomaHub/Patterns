using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero hero = new Hero();

            SaveContainer savegame = new SaveContainer();

            hero.Shoot();
            hero.Shoot();
            hero.Shoot();

            savegame.Saves.Push(hero.SaveState());

            hero.Shoot();
            hero.Shoot();

            hero.RestoreState(savegame.Saves.Pop());

            hero.Shoot();

            Console.ReadLine();
        }
    }
}
