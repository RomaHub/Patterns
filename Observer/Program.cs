using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {

            NPC grunt1 = new NPC("Grunt 1", 12);
            NPC grunt2 = new NPC("Grunt 2", 4);
            NPC grunt3 = new NPC("Grunt 3", 8);
            NPC grunt4 = new NPC("Grunt 4", 10);
            NPC grunt5 = new NPC("Grunt 5", 17);

            Target Beacon = new Target("Beacon");
          
            Beacon.AddListener(grunt1);
            Beacon.AddListener(grunt2);
            Beacon.AddListener(grunt3);
            Beacon.AddListener(grunt4);
            Beacon.AddListener(grunt5);

            Random distanceStrength = new Random();
            int ds = distanceStrength.Next(0, 20);
            Console.WriteLine("Distance: {0} km", ds.ToString());
            Beacon.NotifyListeners(ds);

            Console.ReadLine();

        }
    }
}
