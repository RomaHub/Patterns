using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero hero = new Hero("Bob");

            IAbility backstab = new Backstab();
            IAbility roar = new Roar();
            IAbility stoneskin = new Stoneskin();


            hero.UseAbility();
            
            hero.SetAbility(new Backstab());

            hero.UseAbility();

            hero.LearnAbility(backstab);
            hero.LearnAbility(roar);
            hero.LearnAbility(stoneskin);

            hero.GetAbilities();

            hero.UseAbilityFromList(0);
            
            Console.ReadLine();
        }
    }
}
