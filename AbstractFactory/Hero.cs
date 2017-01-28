using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{

    //Класс клиента Hero использует класс фабрики для создания объектов.
    //При этом он использует исключительно абстрактный класс фабрики HeroCreator
    //и абстрактные классы продуктов Weapon и Movement и никак не зависит от их конкретных реализаций

    class Hero //Client
    {
        private Weapon weapon;
        private Movement movement;

        public Hero(HeroCreator creator)
        {
            weapon = creator.CreateWeapon();
            movement = creator.CreateMovement();
        }

        public void Run()
        {
            movement.Move();
        }

        public void Hit()
        {
            weapon.Hit();
        }

    }
}
