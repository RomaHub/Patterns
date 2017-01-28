using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {

            Cost commonHandgun = new CommonItem("Handgun", 150);
            Cost rareHandgun = new RareItem("Revolver", 350);

            commonHandgun = new Silencer(commonHandgun);
            Console.WriteLine("{0} price: {1} $", commonHandgun.FullName, commonHandgun.GetTotalCost().ToString());
            

            rareHandgun = new Silencer(rareHandgun);
            rareHandgun = new Collimator(rareHandgun);
            Console.WriteLine("{0} price: {1} $", rareHandgun.FullName, rareHandgun.GetTotalCost().ToString());

            Console.ReadLine();

        }
    }
}
