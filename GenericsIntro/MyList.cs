using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T> //T = Type'ın T'si
    {
        //public void Add(string item); sadece string tutar
        T[] items;
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item) //Class'a verilen değişkene göre çalışır
        {
            T[] tempArray = items;
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }
    }
}
