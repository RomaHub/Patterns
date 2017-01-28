using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{

    //ConcreteClass: подкласс, который может переопределять различные методы родительского класса.

    class Handgun : Gunsmith
    {
        public override void DoBase()
        {
            Console.WriteLine("Пистолет");
        }

        public override void AddGadgets()
        {
            Console.WriteLine("Добавил глушитель");
        }

    }

    class Rifle : Gunsmith
    {
        public override void DoBase()
        {
            Console.WriteLine("Винтовка");
        }

        public override void AddGadgets()
        {
            Console.WriteLine("Добавил оптический прицел");
            Console.WriteLine("Добавил подствольный гранатамет");
        }

        public override void CustomePaint()
        {
            Console.WriteLine("Покрасить в матово-черный");
        }

        public override void LoadUp()
        {
            Console.WriteLine("Зарядить созданное оружие расширенным магазином");
        }
    }
}
