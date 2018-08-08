using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labrab8
{
    class Program
    {
        static void Main(string[] args)
        {
            CollectionType<int> set1 = new CollectionType<int>();
            set1.Add(1);
            set1.Add(2);
            set1.Show();
            CollectionType<double> set2 = new CollectionType<double>();
            set2.Add(1.5);
            set2.Add(2.9);
            set2.Show();
            NewClass<Class> cl1 = new NewClass<Class>();
            cl1.Show();
        }
    }
}
