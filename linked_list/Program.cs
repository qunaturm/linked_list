﻿using System;
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
            Model.LinkedList<int> l1 = new Model.LinkedList<int>(1);
            l1.Add(2);
            l1.Add(3);
            l1.Add(4);
            l1.Add(5);
            foreach (var item in l1)
            {
                Console.Write(item + " ");
            }
            Console.ReadLine();
        }
    }
}
