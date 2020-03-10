using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linked_list
{
    class Program
    {
        static void Main(string[] args)
        {
            Model.LinkedList<int> l1 = new Model.LinkedList<int>(1); // or var l1 = new Model.LinkedList<int>(7);
            l1.Add(2);
            l1.Add(3);
            l1.Add(4);
            Console.WriteLine(l1.Head);
            Console.WriteLine(l1.Tail);
            Console.WriteLine(l1.Count);
            Console.ReadLine();

        }
    }
}
