using System;
using System.Collections;

namespace linked_list.Model
{
    public class LinkedList<T> : IEnumerable
    {
        public Item<T> Head { get; private set; }
        public Item<T> Tail { get; private set; }
        public int Count { get; private set; }

        public LinkedList()
        {
            Clear();
        }

        public LinkedList(T Data)
        {
            Item<T> item = new Item<T>(Data); // or var item = new Item<T>(Data);
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

        public void AddToHead(T data)
        {
            if(Head != null)
            {
                Item<T> item = new Item<T>(data);
                item.Next = Head;
                Head = item;
                Count += 1;

            }
        }

        public void AddAfterItem(T elem, T data) //elem - элемент, после которого добавляем, data - то, что добавляем
        {
            if (Head.Next != null)
            {

                var current = Head;
                while(current != null)
                {
                    if(current.Data.Equals(elem))
                    {
                        var item = new Item<T>(data);
                        item.Next = current.Next;
                        current.Next = item;
                        Count += 1;
                        return;
                    }
                    else
                    {
                        current = current.Next;
                    }
                }

            }

        }

        public void Del(T data)
        {
            if (Head != null)
            {

                if (Head.Data.Equals(data))
                {
                    Head = Head.Next;
                    Count -= 1;
                    return;
                }

                Item<T> current = Head.Next; //or var current = Head;
                Item<T> prev = Head;

               while(current != null)
                {
                    if (current.Data.Equals(data))
                    {
                        prev.Next = current.Next;
                        Count -= 1;
                        return;
                    }
                    else
                    {
                        prev = current;
                        current = current.Next;

                    }
                }
                
            }

        }

        private void SetHeadAndTail(T data)
        {
            Item<T> item = new Item<T>(data);

            Head = item;
            Tail = item;
            Count = 1;

        }

        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public IEnumerator GetEnumerator()
        {
            Item<T> currrent = Head;
            while(currrent != null)
            {
                yield return currrent.Data;
                currrent = currrent.Next;
            }
        }
    }
}
