using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex35_observer_pattern
{
    public class ConcreteSubject : Subject
    {
        public int State
        {
            get { return state; }
            set { state = value;
                Notify();
            }
        }

        private int state;
    }
}
