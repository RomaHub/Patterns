using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    //Абстрактные классы Movement и Weapon определяют интерфейс для классов, объекты которых будут создаваться в программе.

    abstract class Weapon
    {
        public abstract void Hit();
    }

    //Конкретные классы Walk / Run и Sword / Bow представляют конкретную реализацию абстрактных классов

    class Sword : Weapon
    {
        public override void Hit()
        {
            Console.WriteLine("Удар мечом");
        }
    }

    class Bow : Weapon
    {
        public override void Hit()
        {
            Console.WriteLine("Выстрел из лука");
        }
    }


}
