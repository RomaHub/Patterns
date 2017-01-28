using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    //State: определяет интерфейс состояния
    interface IEnemyState
    {
        //void UpdateState()
        void ToChaseState(Enemy enemy);
        void ToPatrolState(Enemy enemy);
        void ToAttackState(Enemy enemy);
    }

    //Классы StateA и StateB - конкретные реализации состояний
    class ChaseState : IEnemyState
    {
        public void ToAttackState(Enemy enemy)
        {
            Console.WriteLine("Враг в зоне поражения. Начинаю атаку!");
            enemy.CurrentState = new AttackState();
        }

        public void ToChaseState(Enemy enemy)
        {
            Console.WriteLine("Преследую...");
        }

        public void ToPatrolState(Enemy enemy)
        {
            Console.WriteLine("Враг скрылся. Начинаю патрулирование");
            enemy.CurrentState = new PatrolState();
        }
    }

    class PatrolState : IEnemyState
    {
        public void ToAttackState(Enemy enemy)
        {
            Console.WriteLine("Враг обнаружен. Начинаю атаку!");
            enemy.CurrentState = new AttackState();
        }

        public void ToChaseState(Enemy enemy)
        {
            Console.WriteLine("Враг обнаружен. Начинаю преследование!");
            enemy.CurrentState = new ChaseState();
        }

        public void ToPatrolState(Enemy enemy)
        {
            Console.WriteLine("Патрулирую...");
        }
    }

    class AttackState : IEnemyState
    {
        public void ToAttackState(Enemy enemy)
        {
            Console.WriteLine("Атакую!!!");
        }

        public void ToChaseState(Enemy enemy)
        {
            Console.WriteLine("Враг убегает. Начинаю преследование!");
            enemy.CurrentState = new ChaseState();
        }

        public void ToPatrolState(Enemy enemy)
        {
            Console.WriteLine("Враг скрылся. Начинаю патрулирование");
            enemy.CurrentState = new PatrolState();
        }
    }
}
