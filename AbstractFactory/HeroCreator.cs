using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{

    //Абстрактный класс фабрики HeroCreator определяет методы для создания объектов.
    //Причем методы возвращают абстрактные продукты, а не их конкретные реализации.

    abstract class HeroCreator
    {
        public abstract Weapon CreateWeapon();
        public abstract Movement CreateMovement();
    }

    //Конкретные классы фабрик ElfCreator и HumanCreator реализуют абстрактные методы базового класса
    //и непосредственно определяют какие конкретные продукты использовать

    class ElfCreator : HeroCreator
    {
        public override Weapon CreateWeapon()
        {
            return new Bow();
        }

        public override Movement CreateMovement()
        {
            return new Run();
        }
    }

    class HumanCreator : HeroCreator
    {
        public override Weapon CreateWeapon()
        {
            return new Sword();
        }

        public override Movement CreateMovement()
        {
            return new Walk();
        }
    }
}
