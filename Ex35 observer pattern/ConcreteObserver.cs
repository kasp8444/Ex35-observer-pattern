using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex35_observer_pattern;

namespace Ex35_observer_pattern
{
    public class ConcreteObserver : Observer
    {
        //private string _name;
        private int state;
        public int State
        {
            get { return state; }
            set { state = value; }
        }

        private ConcreteSubject subject;
        public ConcreteObserver(ConcreteSubject subject/*, string name*/)
        {
            this.subject = subject;
            //this.State = state;
        }
        public override void Update()
        {
            State = subject.State;
            //Console.WriteLine("Observer {0}'s new state is {1}", _name, _observerState);
        }
        public ConcreteSubject Subject
        {
            get { return subject; }
            set { subject = value; }
        }
    }
}
