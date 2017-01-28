using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{

    //определяет интерфейс для клонирования самого себя, который, как правило, представляет метод Clone()

    abstract class Prototype
    {
        public abstract Prototype Clone();
    }

    //конкретные реализации прототипа. Реализуют метод Clone()

    class Character : Prototype
    {
        public int hp;
        public int armor;

        public Character(int hp, int armor)
        {
            this.hp = hp;
            this.armor = armor;
        }

        public override Prototype Clone()
        {
            return new Character(hp, armor);
        }

        public void GetCurrentHP()
        {
            Console.WriteLine("Остлось жизней: {0}", hp.ToString());
        }

        public void TakeDamage(int amount)
        {
            if (amount <= armor)
            {
                hp--;
                Console.WriteLine("Очень слабый удар для моей брони. Урон: 1");
            }
            else
            {
                hp -= (amount - armor);
                Console.WriteLine("Хороший удар!. Урон: {0}",amount.ToString());
            }
        }
    }

    //Встроенный интерфейс клонирования

    class Enemy : ICloneable
    {
        public float maxHP;
        public float currentHP;

        public Enemy(float maxHealth)
        {
            maxHP = maxHealth;
            SetCurrentHealthToMax();
        }

        public void SetCurrentHealthToMax()
        {
            currentHP = maxHP;
        }

        public object Clone()
        {
            return new Enemy(maxHP);
        }
    }


}
