using System;

namespace linked_list.Model
{
    public class LinkedList<T>
    {
        public Item<T> Head { get; private set; }
        public Item<T> Tail { get; private set }
        public int count { get; private set; }

        public LinkedList()
        {
            Head = null;
            Tail = null;
            count = 0;
        }

        public LinkedList(T Data)
        {
            Item<T> item = new Item<T>(Data); // or var itm = new Item(Data);
            Head = item;
            Tail = item;
            count = 1;
        }

        public void Add(T data)
        {
            Item <T> item = new Item<T>(data);
            if (Tail != null)
            {
                Tail.Next = item;
                Tail = item;
            }
        }
    }
}
