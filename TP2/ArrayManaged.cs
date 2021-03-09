using System;
using System.Linq;
namespace TP2
{
    public class ArrayManaged
    {
        private int[] items;

        public int Count{
            get;
            private set;
        }

        public int ResizeCount {
            get;
            private set;
        }

        public int Capacity { 
            get{
            return items.Length;
            }
        }

        public ArrayManaged(){
            items = new int [1];
            Count = 0;
            ResizeCount = 0;
        }    

        public ArrayManaged(int quantity)
        {
            items = new int[quantity];
            Count = 0;
            ResizeCount = 0;
        }  

        public int Get(int position)
        {
            if (position >= Count)
            {
                return -1;
            }
            return items [position];
        }

        public int Search(int item)
        {
            for(int index = 0; index<Count; index++)
            {
                if(items[index] == item)
                {
                    return index;
                }
                
            }
            return -1;
        }

        public void Add(int item)
        {
            if (Count >=  Capacity)
            {
                Resize();
            }
            items[Count] = item;
            Count ++;
        }

        public void RemoveItem(int _item)
        {
            int position = -1;
            for (int i = 0; i< Count; i++)
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
            int [] _temp = new int[Capacity * 2];
            for(int i = 0; i < Capacity; i++)
            {
                _temp[i] = items[i];
            }
            items = _temp;
            ResizeCount++;
        }


    }
}