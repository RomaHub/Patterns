using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    //Builder: определяет интерфейс для создания различных частей объекта Product
    abstract class ItemBuilder
    {
        public abstract void BuildPart1();
        public abstract void BuildPart2();
        public abstract void BuildPart3();

        public abstract Item GetBuildedItem();
    }

    //ConcreteBuilder: конкретная реализация Buildera. Создает объект Product и определяет интерфейс для доступа к нему
    class CommonSwordBuilder : ItemBuilder
    {
        private Item _item = new Item("Обычный меч");

        public override void BuildPart1()
        {
            _item.AddPart("Созданы основные параметры.");
        }

        public override void BuildPart2()
        {
 
        }

        public override void BuildPart3()
        {

        }

        public override Item GetBuildedItem()
        {
            return _item;
        }
    }

    class RareSwordBuilder : ItemBuilder
    {
        private Item _item = new Item("Редкий меч");

        public override void BuildPart1()
        {
            _item.AddPart("Созданы основные параметры.");
        }

        public override void BuildPart2()
        {
            _item.AddPart(" Добавлены способности.");
        }

        public override void BuildPart3()
        {

        }

        public override Item GetBuildedItem()
        {
            return _item;
        }
    }

    class EpicSwordBuilder : ItemBuilder
    {
        private Item _item = new Item("Эпический меч");

        public override void BuildPart1()
        {
            _item.AddPart("Созданы основные параметры.");
        }

        public override void BuildPart2()
        {
            _item.AddPart(" Добавлены способности.");
        }

        public override void BuildPart3()
        {
            _item.AddPart(" +Индивидуальный вид");
        }

        public override Item GetBuildedItem()
        {
            return _item;
        }
    }

    //Product: представляет объект, который должен быть создан. В данном случае все части объекта заключены в списке parts.
    class Item
    {
        public string itemName;

        public Item(String _name)
        {
            itemName = _name;
        }

        public List<String> parts = new List<string>();

        public void AddPart(String partName)
        {
            parts.Add(partName);
        }

        public void ShowAllParts()
        {
            StringBuilder sb = new StringBuilder();

            foreach (String s in parts)
            {
                sb.Append(s);
            }

            Console.WriteLine(itemName + " : "+ sb);
        }
    }


}
