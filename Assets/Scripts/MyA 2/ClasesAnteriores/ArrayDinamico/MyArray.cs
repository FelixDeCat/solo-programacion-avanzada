namespace Clases2025
{
    using UnityEngine;

    [System.Serializable]
    public class MyArray<T>
    {
        private int count = 0;
        public int Count
        {
            get { return count; }
        }
        public int Capacity
        {
            get { return array.Length; }
        }

        [SerializeField] private T[] array;

        public T this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                array[index] = value;
            }
        }
        public T GetElement(int index)
        {
            return array[index];
        }

        public MyArray()
        {
            array = new T[0];
            count = 0;
        }
        public MyArray(T[] array)
        {
            this.array = array;
            count = array.Length;
        }
        //public MyArray(int capacity = 5)
        //{
        //    array = new T[capacity];
        //    count = 0;
        //}
        public void Add(T item) // 3 5 8 -> 9
        {
            if (array.Length == 0)
            {
                Debug.Log("agrego primer elemento");
                array = new T[1];
                array[0] = item;
            }
            else
            {
                Debug.Log("Resize");
                if (count >= Capacity)
                {
                    int newSize = array.Length * 2;
                    var old = array; // 3 5 8 0 0 0
                    array = new T[newSize]; // 0 0 0 0 0 0
                    for (int i = 0; i < old.Length; i++)
                    {
                        array[i] = old[i]; // 3 5 8 0 0 0
                    }
                    array[old.Length] = item;// 3 5 8 9 0 0
                }
                else
                {
                    array[count] = item;
                }
            }

            count++;
        }
    }
}