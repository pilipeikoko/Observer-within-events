using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesTest
{
    class Person
    {
        public string Name { get; private set; }
        public int Age { get; set; }


        public delegate void EventHandler(Person person);
        private event EventHandler eventHandler;

        public void ChangeSomeStates(int age,string name)
        {
            this.Age = age;
            this.Name = name;
            NotifyObservers();
        }

        public void NotifyObservers()
        {

            this.eventHandler?.Invoke(this);
        }

        public void AddEvent(EventHandler eventHandler)
        {
            this.eventHandler += eventHandler;
        }

        public void RemoveEvent(EventHandler eventHandler)
        {
            this.eventHandler -= eventHandler;
        }

    }

    


}
