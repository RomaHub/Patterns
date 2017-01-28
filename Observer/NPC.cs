using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    //ConcreteObserver: конкретная реализация интерфейса IObserver.

    class NPC : IListener
    {
        string npcName;
        int distanceToTarget;

        public NPC(string name, int dist)
        {
            npcName = name;
            distanceToTarget = dist;
        }

        public void Update(object o, int d)
        {
            if(distanceToTarget <= d)
            Console.WriteLine("I hear name:[{0}] distance [{1}] km to target:[{2}]", npcName, distanceToTarget.ToString(), o.ToString());
        }
    }


}
