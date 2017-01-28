using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Enemy enemy = new Enemy(new PatrolState());

            enemy.Chase();
            enemy.Attack();
            enemy.Attack();
            enemy.Patrol();

            Console.ReadLine();
        }
    }
}
