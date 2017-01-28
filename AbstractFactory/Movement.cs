using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    //Абстрактные классы Movement и Weapon определяют интерфейс для классов, объекты которых будут создаваться в программе.

    abstract class Movement
    {
        public abstract void Move();
    }

    //Конкретные классы Walk / Run и Sword / Bow представляют конкретную реализацию абстрактных классов

    class Walk : Movement
    {
        public override void Move()
        {
            Console.WriteLine("Идет");
        }
    }

    class Run : Movement
    {
        public override void Move()
        {
            Console.WriteLine("Бежит");
        }
    }


}
