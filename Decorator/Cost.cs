using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{

    //Component: абстрактный класс, который определяет интерфейс для наследуемых объектов

    abstract class Cost
    {
        public string FullName { get; protected set; }
        public int Money { get; set; }

        public Cost(string name, int m)
        {
            FullName = name;
            Money = m;
        }

        public abstract int GetTotalCost();
    }

    //ConcreteComponent: конкретная реализация компонента, в которую с помощью декоратора добавляется новая функциональность

    class CommonItem : Cost
    {
        public CommonItem(string iName, int m) : base(iName, m)
        {
        }

        public override int GetTotalCost()
        {
            return Money;
        }
    }

    class RareItem : Cost
    {
        public RareItem(string iName, int m) : base(iName, m)
        {
        }

        public override int GetTotalCost()
        {
            return Money;
        }
    }

}
