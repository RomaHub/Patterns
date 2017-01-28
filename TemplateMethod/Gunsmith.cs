using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{

    //AbstractClass: определяет шаблонный метод TemplateMethod(), который реализует алгоритм.
    //Алгоритм может состоять из последовательности вызовов других методов,
    //часть из которых может быть абстрактными и должны быть переопределены в классах-наследниках.
    //При этом сам метод TemplateMethod(), представляющий структуру алгоритма, переопределяться не должен.

    abstract class Gunsmith
    {
        public void CreateGun()
        {
            DoBase();
            AddGadgets();
            CustomePaint();
            LoadUp();
        }

        public abstract void DoBase();
        public abstract void AddGadgets();
        public virtual void CustomePaint()
        {
            Console.WriteLine("Покрасить в металлик");
        }
        public virtual void LoadUp()
        {
            Console.WriteLine("Зарядить созданное оружие");
        }
    }
}
