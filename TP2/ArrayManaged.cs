using System;
using System.Linq;

namespace TP2
{
    public class ArrayManaged
    {
        private long[] items;

        public long Count{
            get;
            private set;
        }

        public long ResizeCount {
            get;
            private set;
        }

        public long Capacity { 
            get{
            return items.Length;
            }
        }

        public long Max{
            get {
                return items.Max();
            }
        }

        public long Min{
            get{
                return items.Min();
            }
        }

        public long Average{
            get{
                long average = 0;
                long count = 0;
                foreach(long item in items)
                {
                    average += item;
                    count ++;
                }
                return average/count;
            }
        }
        public static void PrintArray(ArrayManaged array)
        {
            foreach(var item in array.items)
            {
                Console.Write($"{item} - ");
            }
        }
       

        public ArrayManaged(){
            items = new long [1];
            Count = 0;
            ResizeCount = 0;
        }    

        public ArrayManaged(long quantity)
        {
            items = new long[quantity];
            Count = 0;
            ResizeCount = 0;
        }  

        public long Get(long position)
        {
            if (position >= Count)
            {
                return -1;
            }
            return items [position];
        }

        public long Search(long item)
        {
            for(long index = 0; index<Count; index++)
            {
                if(items[index] == item)
                {
                    return index;
                }
                
            }
            return -1;
        }

        public void Add(long item)
        {
            if (Count >=  Capacity)
            {
                Resize();
            }
            items[Count] = item;
            Count ++;
        }

        public void RemoveItem(long _item)
        {
            long position = -1;
            for (long i = 0; i< Count; i++)
            {
                if(items[i] == _item)
                {
                    position = i;
                    break;
                }
            }
            items[position] = items[Count - 1];
            Count--;
        }

        private void Resize()
        {
            long [] _temp = new long[Capacity * 2];
            for(long i = 0; i < Capacity; i++)
            {
                _temp[i] = items[i];
            }
            items = _temp;
            ResizeCount++;
        }
    }
}