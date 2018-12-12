using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex35_observer_pattern
{
    public abstract class Subject
    {
        //private Observer observer;
        private List<Observer> _observers = new List<Observer>();
        
        public void Attach(Observer o)
        {
            _observers.Add(o);
        }

        public void Detach(Observer o)
        {
            _observers.Remove(o);
        }

        public void Notify()
        {
            foreach (Observer o in _observers)
            {
                o.Update();
            }
        }
    }
}
