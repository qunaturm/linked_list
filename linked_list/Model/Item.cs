using System;

namespace linked_list.Model
{
    public class Item<T>
    {
        private T data = default(T);
        //private Item<T> next = null;

        public T Data
        {
            get => data; //?
            set
            {
                if (value != null) data = value;
                else throw new ArgumentNullException(nameof(value));
            }
        }

        public Item<T> Next { get; set;}

        public Item(T Data)
        {
            this.Data = Data;
        }
        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
