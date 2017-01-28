using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            UI ui = new UI();
            Movement move = new Movement();

            Action command = new MoveAction(move);

            ui.SetAction(command);

            ui.PressRightButton();
            ui.PressLeftButton();

            Console.ReadLine();
        }
    }
}
