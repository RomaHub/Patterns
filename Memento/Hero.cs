using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{

    //Originator: создает объект хранителя для сохранения своего состояния

    class Hero
    {
        private int patrons = 10; // кол-во патронов
        private int lives = 5; // кол-во жизней

        public void Shoot()
        {
            if (patrons > 0)
            {
                patrons--;
                Console.WriteLine("Производим выстрел. Осталось {0} патронов", patrons);
            }
            else
                Console.WriteLine("Патронов больше нет");
        }
        // сохранение состояния
        public HeroData SaveState()
        {
            Console.WriteLine("Сохранение игры. Параметры: {0} патронов, {1} жизней", patrons, lives);
            return new HeroData(patrons, lives);
        }

        // восстановление состояния
        public void RestoreState(HeroData data)
        {
            patrons = data.Patrons;
            lives = data.Lives;
            Console.WriteLine("Восстановление игры. Параметры: {0} патронов, {1} жизней", patrons, lives);
        }
    }

    //Memento: хранитель, который сохраняет состояние объекта Originator и предоставляет полный доступ только этому объекту Originator

    class HeroData
    {
        public int Patrons { get; private set; }
        public int Lives { get; private set; }

        public HeroData(int patrons, int lives)
        {
            Patrons = patrons;
            Lives = lives;
        }
    }
}
