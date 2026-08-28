namespace Clases2025
{
    using UnityEngine;

    public class EjemploUsoArrayDinamico : MonoBehaviour
    {
        [SerializeField] MyArray<int> myArray;

        void Start()
        {
            myArray = new MyArray<int>();
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.T))
            {
                myArray.Add(Random.Range(0, 100)); //0 a 99
                myArray.Add(Random.Range(0, 100)); //0 a 99
                myArray.Add(Random.Range(0, 100)); //0 a 99
                //myArray[0] = Random.Range(0, 100);

                foreach (var item in myArray) 
                { 
                    print(item); 
                }
            }
        }
    }
}