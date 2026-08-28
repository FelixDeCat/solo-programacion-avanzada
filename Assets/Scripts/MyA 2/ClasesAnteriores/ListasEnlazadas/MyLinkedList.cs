namespace Clases2025
{
    using System;

    public class MyLinkedList<T>
    {
        Node<T> first;
        Node<T> last;
        int count = 0;

        public MyLinkedList()
        {
            first = null;
            last = null;
            count = 0;
        }

        public int Count
        {
            get
            {
                return count;
            }
        }

        public void AddLast(T data)
        {
            Node<T> current = new Node<T>(data);

            if (first == null) //no tenia nada
            {
                first = current;
                last = current;
            }
            else
            {
                last.Next = current; //primero conecto
                last = current; //me corono
            }
            count++;
        }

        public void AddFirst(T data)
        {
            Node<T> current = new Node<T>(data);

            if (last == null)
            {
                first = current;
                last = current;
            }
            else
            {
                current.Next = first; //primero conecto
                first = current; //me corono
            }
            count++;
        }

        public void RemoveLast()
        {
            if (first == null)
            {
                return;
            }
            if (first == last)
            {
                first = null;
                last = null;
                count = 0;
            }
            else
            {
                var current = first; //seed
                while (current.Next != last)
                {
                    current = current.Next; //Forwarding >>
                }
                current.Next = null;
                last = current; ///corono
                count--;
            }

        }
        public void RemoveFirst()
        {
            if (first == null)
            {
                return;
            }
            if (first == last)
            {
                first = null;
                last = null;
                count = 0;
            }
            else
            {
                first = first.Next;
                count--;
            }
        }

        public T GetByIndex(int index)
        {
            var current = first;

            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }

            return current.Data;
        }

        public void Debug(Action<object> deb)
        {
            string msg = "";
            var current = first;
            while (current.Next != null)
            {
                msg += "[" + current.Data.ToString() + "]";

                current = current.Next;
            }

            msg += "[" + current.Data.ToString() + "]";

            deb.Invoke(msg);
        }


    }
}
