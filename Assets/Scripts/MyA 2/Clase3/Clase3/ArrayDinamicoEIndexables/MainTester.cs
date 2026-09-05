using System.Collections.Generic;
using UnityEngine;

public class MainTester : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        int[,] myMatrix = new int[20, 20];
        for (int i = 0; i < myMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < myMatrix.GetLength(1); j++)
            {
                myMatrix[i, j] = Random.Range(0,100);
            }
        }


        //TestIndexer indexer = new TestIndexer();

        //indexer[0] = "pepe";

        //print(indexer[1]);


        DinamicArray<int> myCustomArrayNada = new DinamicArray<int>();
        DinamicArray<int> myCustomArraytresElementos = new DinamicArray<int>(new[] { 20,34,54 });
        DinamicArray<int> myCustomArrayConCap = new DinamicArray<int>(20);


        DinamicArray<string> myCustomArrayString = new DinamicArray<string>();

        foreach (var item in myCustomArrayString)
        {

        }


        myCustomArrayNada.Add(20); /// [20]

        myCustomArraytresElementos.Add(20); //  [ 20, 34, 54] -> [20, 34, 54, 20, 0,  0] // count 4 cap 6

        myCustomArrayConCap.Add(20); // [ 20 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0] // cap 20 count 1


        for (int i = 0; i < myCustomArraytresElementos.Count; i++)
        {
            print(myCustomArraytresElementos[i]);
        }

        LinkedList<int > myLinkedList = new LinkedList<int>();

        myLinkedList.AddToLast(20);
        myLinkedList.AddToLast(30);


        foreach (var e in myLinkedList)
        {

        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
