using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{

    //Decorator: собственно декоратор, реализуется в виде абстрактного класса и имеет тот же базовый класс,
    //что и декорируемые объекты. Поэтому базовый класс Component должен быть по возможности легким
    //и определять только базовый интерфейс.

    //Класс декоратора также хранит ссылку на декорируемый объект в виде объекта базового класса Component
    //и реализует связь с базовым классом как через наследование, так и через отношение агрегации.
    
    abstract class Gadget : Cost
    {
        protected Cost item;

        public Gadget(string gName, int m, Cost item) : base(gName, m)
        {
            this.item = item;
        }

    }

    //Классы ConcreteDecoratorA и ConcreteDecoratorB представляют дополнительные функциональности,
    //которыми должен быть расширен объект ConcreteComponent. ConcreteDecoratorA добавляет новое свойство NewState,
    //а ConcreteDecoratorB добавляет новый метод NewMethod(). Подобных классов может быть множество.
    //И они не обязательно должны что-то добавлять: свойства, методы. Они просто могут переопределять уже имеющийся функционал.

    class Silencer : Gadget
    {

        public Silencer(Cost item) : base(item.FullName + " + Silencer", 150, item)
        {
        }

        public override int GetTotalCost()
        {
            return item.GetTotalCost() + Money;
        }
    }

    class Collimator : Gadget
    {

        public Collimator(Cost item) : base(item.FullName + " + Collimator", 200, item)
        {
        }

        public override int GetTotalCost()
        {
            return item.GetTotalCost() + Money;
        }
    }
}
