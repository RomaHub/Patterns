using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    //Context: представляет объект, поведение которого должно динамически изменяться в соответствии с состоянием.
    //Выполнение же конкретных действий делегируется объекту состояния.
    class Enemy
    {
        public IEnemyState CurrentState { get; set; }

        public Enemy(IEnemyState state)
        {
            CurrentState = state;
        }

        public void Chase()
        {
            CurrentState.ToChaseState(this);
        }

        public void Patrol()
        {
            CurrentState.ToPatrolState(this);
        }

        public void Attack()
        {
            CurrentState.ToAttackState(this);
        }
    }
}
