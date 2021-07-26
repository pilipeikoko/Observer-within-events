using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesTest
{
    class Warehouse
    {


        public void Subscribe(Person person)
        {
            person.AddEvent(DoSomething);
        }

        private void DoSomething(Person person)
        {
            Console.WriteLine("Warehouse says: Person parameters were changed");
      }


    }
}
