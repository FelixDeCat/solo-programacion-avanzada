using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinamicArray<T> : IEnumerable<T>
{
    T[] array;
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
    private int count = 0;
    public int Count /// voy contando ++ o --
    {
        get { return count; } //solo lectura
    }
    public int Capacity
    {
        get
        {
            return array.Length; // tamaño real ocupado en memoria
        }
    }

    public DinamicArray()
    {
        count = 0;
        array = new T[0];
    }
    public DinamicArray(int defaultCapacity = 10)
    {
        count = 0;
        array = new T[defaultCapacity];
    }
    public DinamicArray(T[] arrayCopy)
    {
        this.array = arrayCopy;
        count = array.Length;
    }


    public void Add(T item)
    {
        if (array.Length == 0)
        {
            array = new T[1];
            array[0] = item;
        }
        else
        {
            Debug.Log("Estoy escalando");
            // Resize
            if (count >= Capacity)
            {
                int newSize = array.Length * 2;
                var old = array; /// 1234
                array = new T[newSize]; // 00000000
                for (int i = 0; i < old.Length; i++)
                {
                    Debug.Log("Pasando nuevo valor: " + old[i]);

                    array[i] = old[i];
                }
                array[old.Length] = item;
            }
            else
            {
                array[count] = item;
            }
        }

        count++;
    }

    int aux = 0;
    bool condZaraza = false;
    T current;

    public IEnumerator<T> GetEnumerator()
    {

        //foreach (T item in array)
        //{
        //    yield return item;
        //}

        for (int i = 0; i < count; i++)
        {
            yield return array[i];
        }


        //condZaraza = true;
        //int condCut = Random.Range(5, 10);
        //while (condZaraza)
        //{
        //    yield return current;
        //    aux++;
        //    if (aux > condCut)
        //    {
        //        condZaraza = false;
        //        break;
        //    }
        //    yield return current;
        //}
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
