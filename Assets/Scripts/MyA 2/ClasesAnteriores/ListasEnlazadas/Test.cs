namespace Clases2025
{

    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class Test : MonoBehaviour
    {
        [SerializeField]
        MyLinkedList<int> myLkdList;

        void Start()
        {
            myLkdList = new MyLinkedList<int>();

            myLkdList.AddLast(10);
            myLkdList.AddLast(20);
            myLkdList.AddLast(30);
            myLkdList.AddLast(40);
            myLkdList.AddFirst(9);
            myLkdList.AddFirst(8);
            myLkdList.AddFirst(7);
            myLkdList.AddFirst(6);
            myLkdList.RemoveLast();
            myLkdList.RemoveFirst();

            // 7 8 9 10 20 30

            myLkdList.Debug(x => Debug.Log(x));

            Debug.Log(myLkdList.GetByIndex(2)); //9
        }

        void Update()
        {

        }
    }
}
