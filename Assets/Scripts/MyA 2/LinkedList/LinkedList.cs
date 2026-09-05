using MyCustomCollections;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkedList<T> : IEnumerable<T>
{
    Node<T> first;
    Node<T> last;
    int count = 0;

    public LinkedList()
    {
        first = null;
        count = 0;
    }
    //public LinkedList(IEnumerable<T> col) // si quieren replicar una coleccion
    //{
    //    first = null;
    //    count = 0;
    //}

    public int Count
    {
        get
        {
            return count;
        }
    }

    // Con Forwarding >>>
    //public void AddToLast(T data)
    //{
    //    Node<T> newNode = new Node<T>(data);
    //    if (first == null)
    //    {
    //        first = newNode;
    //    }
    //    //Independientemente de si el nodo Nuevo era el primero o no, necesito una semilla
    //    Node<T> current = first;
    //    //forwarding >>>
    //    while (current.Next != null)
    //    {
    //        current = current.Next;
    //    }
    //    current.Next = newNode;
    //  count++;
    //}

    public void AddToLast(T data)
    {
        Node<T> newNode = new Node<T>(data);

        if (first == null)
        {
            first = newNode;
            last = newNode;
        }
        else
        {
            last.Next = newNode;
            last = newNode;
        }
        count++;
    }
    public void AddToFirst(T data)
    {
        Node<T> newNode = new Node<T>(data);

        if (first == null)
        {
            first = newNode;
            last = newNode;
        }
        else
        {
            newNode.Next = first;
            first = newNode;
        }
        count++;
    }

    public void RemoveFromLast(T data)
    {
        /// checkeos
        if (first == null) return;
        if (first == last)
        {
            first = null;
            last = null;
            count = 0;
        }
        else
        {
            var current = first; // seed
            while (current.Next != last) // Deja de Repetir cuando mi siguiente sea el Ultimo
            {
                current = current.Next;
            }
            current.Next = null;
            last = current;
            count--;

        }
    }

    public void RemoveFromFirst(T data)
    {

    }

    public void GetByIndex(int index)
    {
        // pueden hacerlo con esta funcion o usar un Indexer
    }

    public T this[int index] // el indexer
    {
        set {  }
        get { return default; }
    }

    public void Insert(int position, T data)
    {

    }

    public IEnumerator<T> GetEnumerator()
    {
        // implementacion de ustedes

        //usar forwarding e ir devolviendon de a poquito

        yield return default(T);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
