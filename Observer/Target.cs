using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    //ConcreteObservable: конкретная реализация интерфейса IObservable. Определяет коллекцию объектов наблюдателей.

    class Target : IObservable
    {
        string targetName;

        public Target(string name)
        {
            targetName = name;
        }

        List<IListener> listeners = new List<IListener>();

        public void AddListener(IListener listener)
        {
            listeners.Add(listener);
        }

        public void RemoveListener(IListener listener)
        {
            listeners.Remove(listener);
        }

        public void NotifyListeners(int d)
        {
            if (d <= 0) return;

            foreach (IListener l in listeners)
            {
                l.Update(this, d);
            }
        }

        public override string ToString()
        {
            return targetName;
        }

    }


}
