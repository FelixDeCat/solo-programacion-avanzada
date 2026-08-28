namespace Clases2025
{
    public class Node<T>
    {
        // data
        T data;
        public T Data { get => data; }

        // siguiente
        Node<T> prev;
        Node<T> next;
        public Node<T> Next
        {
            get { return next; }
            set { next = value; }
        }

        public Node(T _data)
        {
            data = _data;
        }
    }
}