using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    //Класс Context хранит ссылку на объект IStrategy и связан с интерфейсом IStrategy отношением агрегации.
    class Hero
    {
        public string HeroName { get; private set; }
        private List<IAbility> abilities = new List<IAbility>();

        public IAbility ability;

        public Hero(string _name, IAbility baseAbility = null)
        {
            HeroName = _name;
            ability = baseAbility;
        }


        public void SetAbility(IAbility a)
        {
            ability = a;
        }

        public void ForgetAbility()
        {
            ability = null;
        }

        public void UseAbility()
        {
            if(ability!=null) 
               ability.Apply();
            else Console.WriteLine("Ничего не умею");
        }


        public void LearnAbility(IAbility a)
        {
            if (!abilities.Contains(a))
                abilities.Add(a);
        }

        public void GetAbilities()
        {
            foreach (IAbility a in abilities)
            {
                Console.WriteLine("{0} have ability: {1}", HeroName, a.AbilityName);
            }
        }

        public void UseAbilityFromList(int i)
        {
            if(i > abilities.Count-1)
                Console.WriteLine("Такому я еще не обучился");
            else abilities[i].Apply();

        }

    }
}
