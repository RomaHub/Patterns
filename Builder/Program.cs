using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            ItemBuilder commonBuilder = new CommonSwordBuilder();
            ItemBuilder rareBuilder = new RareSwordBuilder();
            ItemBuilder epicBuilder = new EpicSwordBuilder();

            Blacksmith smith = new Blacksmith();
            //smith.CreateCommonItem();
            //smith.CreateRareItem();

            Item item = smith.CreateEpicItem(epicBuilder);
            item.ShowAllParts();

            Console.ReadLine();
        }
    }
}
