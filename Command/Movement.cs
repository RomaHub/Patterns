using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{

    //Receiver: получатель команды. Определяет действия, которые должны выполняться в результате запроса.
    class Movement
    {
        public void StepForward()
        {
            Console.WriteLine("Шаг вперед");
        }

        public void StepBack()
        {
            Console.WriteLine("Шаг назад");
        }

    }

    //Invoker: инициатор команды - вызывает команду для выполнения определенного запроса
    class UI
    {
        Action action;

        public void SetAction(Action _action)
        {
            action = _action;
        }

        public void PressRightButton()
        {
            action.Execute();
        }

        public void PressLeftButton()
        {
            action.Undo();
        }
    }
}
