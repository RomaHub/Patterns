using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{

    //IObserver: представляет наблюдателя, который подписывается на все уведомления наблюдаемого объекта.
    //Определяет метод Update(), который вызывается наблюдаемым объектом для уведомления наблюдателя.

    interface IListener
    {
        void Update(object o, int d);
    }

    //IObservable: представляет наблюдаемый объект. Определяет три метода:
    //AddObserver() (для добавления наблюдателя), RemoveObserver() (удаление набюдателя) и NotifyObservers() (уведомление наблюдателей)

    interface IObservable
    {
        void AddListener(IListener listener);
        void RemoveListener(IListener listener);
        void NotifyListeners(int distance);
    }
}
