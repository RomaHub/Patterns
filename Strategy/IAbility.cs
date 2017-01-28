using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    //Интерфейс IStrategy, который определяет метод Algorithm().
    //Это общий интерфейс для всех реализующих его алгоритмов.
    //Вместо интерфейса здесь также можно было бы использовать абстрактный класс.
    interface IAbility
    {
        string AbilityName { get; set; }
        void Apply();
    }

    //Классы ConcreteStrategy1 и ConcreteStrategy, которые реализуют интерфейс IStrategy,
    //предоставляя свою версию метода Algorithm(). Подобных классов-реализаций может быть множество.
    class Backstab : IAbility
    {
        public string AbilityName { get; set; }

        public Backstab()
        {
            AbilityName = "Backstab";
        }
     

        public void Apply()
        {
            Console.WriteLine("Коварный удар в спину");
        }
    }

    class Roar : IAbility
    {
        public string AbilityName { get; set; }

        public Roar()
        {
            AbilityName = "Roar";
        }

        public void Apply()
        {
            Console.WriteLine("Дикий рев");
        }
    }

    class Stoneskin : IAbility
    {
        public string AbilityName { get; set; }

        public Stoneskin()
        {
            AbilityName = "Stoneskin";
        }

        public void Apply()
        {
            Console.WriteLine("Каменная кожа");
        }
    }
}
