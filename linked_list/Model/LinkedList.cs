using System;

namespace linked_list.Model
{
    public class LinkedList<T>
    {
        public Item<T> Head { get; private set; }
        public Item<T> Tail { get; private set; }
        public int Count { get; private set; }

        public LinkedList()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public LinkedList(T Data)
        {
            Item<T> item = new Item<T>(Data); // or var itm = new Item<T>(Data);
            SetHeadAndTail(item);
        }

        public void Add(T data)
        {
            Item <T> item = new Item<T>(data);
            if (Tail != null)
            {
                Tail.Next = item;
                Tail = item;
                Count += 1;
            }
            else
            {
                SetHeadAndTail(item);
            }
        }
        private void SetHeadAndTail(Item<T> data)
        {
            Head = data;
            Tail = data;
            Count = 1;

        }
    }
}
