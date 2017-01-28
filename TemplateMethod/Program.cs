using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Handgun pistol = new Handgun();
            Rifle assault = new Rifle();

            Console.WriteLine("-------------------");
            pistol.CreateGun();
            Console.WriteLine("-------------------");
            assault.CreateGun();

            Console.ReadLine();
        }
    }
}
