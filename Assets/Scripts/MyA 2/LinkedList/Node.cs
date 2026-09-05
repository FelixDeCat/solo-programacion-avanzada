using UnityEngine;

namespace MyCustomCollections
{
    public class Node<T>
    {
        Node<T> next;
        T data;


        public T Data { get => data; }
        //public void SetData(T _data) => data = _data;
        public Node(T _data)
        {
            data = _data;
        }
        //public Node()
        //{

        //}


        /// Forma de Propiedad opcion 1
        public Node<T> Next
        {
            get { return next; }
            set { next = value; }
        }

        // Forma de Funciones opcion 2
        public void SetNext(Node<T> _next)
        {
            next = _next;
        }
        public Node<T> GetNext()
        {
            return next;
        }
    }
}


