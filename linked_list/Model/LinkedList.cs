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
            SetHeadAndTail(Data);
        }

        public void Add(T data)
        {
            if (Tail != null)
            {
                Item<T> item = new Item<T>(data);
                Tail.Next = item;
                Tail = item;
                Count += 1;
            }
            else
            {
                SetHeadAndTail(data);
            }
        }
        private void SetHeadAndTail(T data)
        {
            Item<T> item = new Item<T>(data);

            Head = item;
            Tail = item;
            Count = 1;

        }
    }
}
