using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesTest
{
    class ObservableCollectionTesting
    {
        static void Main(string[] args)
        {
            ObservableCollection<Person> collection = new ObservableCollection<Person>();
            collection.CollectionChanged += Users_CollectionChanged;
            collection.Add(new Person() { Age = 12 });
            collection.Add(new Person() { Age = 13 });
            collection.RemoveAt(2);
        }


        private static void Users_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    {
                        Console.WriteLine("Added " + e.NewItems);
                        break;
                    }
                case NotifyCollectionChangedAction.Remove:
                    {
                        Console.WriteLine("Removed " + e.OldItems);
                        break;
                    }
            }

        }
    }
}
