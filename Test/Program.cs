using System;

namespace DelegatesTest
{
    class Program
    {

        static void Main(string[] args)
        {
            Person person = new();
            Warehouse warehouse = new();

            warehouse.Subscribe(person);

            person.ChangeSomeStates(12, "Hello");
        }


    }
}
