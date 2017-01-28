﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{

    //Caretaker: выполняет только функцию хранения объекта Memento, в то же время у него нет полного доступа
    //к хранителю и никаких других операций над хранителем, кроме собственно сохранения, он не производит

    class SaveContainer
    {
        public Stack<HeroData> Saves { get; private set; }
        public SaveContainer()
        {
            Saves = new Stack<HeroData>();
        }
    }
}
