using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    /// <summary>
    /// Абстрактный класс Character определяет интерфейс класса, объекты которого надо создавать.
    /// </summary>
    abstract class Character
    {

    }

    //Конкретные классы Fighter и Hunter представляют реализацию класса Character. Таких классов может быть множество

    class Fighter : Character
    {
        public Fighter()
        {
            Console.WriteLine("Персонаж Боец создан");
        }
    }

    class Hunter : Character
    {
        public Hunter()
        {
            Console.WriteLine("Персонаж Охотник создан");
        }
    }
}
