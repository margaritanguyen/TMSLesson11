using System;

namespace TMSLesson11
{
    public class GenericArrayClass<T>
    {
        private T[] array = new T[10];
        private int elementsCount;

        public void Add(T item)
        {
            if (elementsCount < array.Length)
            {
                array[elementsCount] = item;
                elementsCount++;
            }
            else
            {
                throw new Exception("Массив заполнен");
            }
        }

        public T GetElement(int index)
        {
            return array[index];
        }

        public int Count()
        {
            return elementsCount;
        }
    }
}
