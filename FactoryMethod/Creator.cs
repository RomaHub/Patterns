using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    /// <summary>
    /// Абстрактный класс Creator определяет абстрактный фабричный метод Create(), который возвращает объект Character.
    /// </summary>
    abstract class Creator
    {
        public abstract Character Create();
    }

    //Конкретные классы FighterCreator и HunterCreator - наследники класса Creator, определяющие свою реализацию метода Create()
    //Причем метод Create() каждого отдельного класса-создателя возвращает определенный конкретный тип продукта.
    //Для каждого конкретного класса продукта определяется свой конкретный класс создателя.

    class FighterCreator : Creator
    {
        public override Character Create()
        {
            return new Fighter();
        }
    }

    class HunterCreator : Creator
    {
        public override Character Create()
        {
            return new Hunter();
        }
    }
}
