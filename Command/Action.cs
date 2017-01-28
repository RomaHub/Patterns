using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{

    //Command: интерфейс, представляющий команду. Обычно определяет метод Execute() для выполнения действия,
    //а также нередко включает метод Undo(), реализация которого должна заключаться в отмене действия команды
    abstract class Action
    {
        public abstract void Execute();
        public virtual void Undo()
        { }
    }

    //ConcreteCommand: конкретная реализация команды, реализует метод Execute(),
    //в котором вызывается определенный метод, определенный в классе Receiver
    class MoveAction : Action
    {
        Movement movement;

        public MoveAction(Movement m)
        {
            movement = m;
        }
        
        public override void Execute()
        {
            movement.StepForward();
        }

        //можно не переопределять
        public override void Undo()
        {
            movement.StepBack();
        }
    }

}
