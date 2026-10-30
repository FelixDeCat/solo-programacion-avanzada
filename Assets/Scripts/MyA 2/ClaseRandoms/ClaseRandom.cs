using UnityEngine;

public class ClaseRandom : MonoBehaviour
{

    public int[] col = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

    void Start()
    {
        #region Test Sequencia + Random de Microsoft
        //Random.InitState(12345);
        int val = 0;

        //print("----------------------");
        //Random.InitState(12345);
        //val = Random.Range(10,100); // General
        //print("1- " + val);
        //val = Random.Range(10, 100); // General
        //print("2- " + val);
        //val = Random.Range(10, 100); // General
        //print("3- " + val);
        //val = Random.Range(10, 100); // General
        //print("4- " + val);
        //print("----------------------");
        //Random.InitState(12345);
        //val = Random.Range(10,100); // General
        //print("1- " + val);
        //val = Random.Range(10, 100); // General
        //print("2- " + val);
        //val = Random.Range(10, 100); // General
        //print("3- " + val);
        //val = Random.Range(10, 100); // General
        //print("4- " + val);
        //print("----------------------");
        //Random.InitState(12345);
        //val = Random.Range(10,100); // General
        //print("1- " + val);
        //val = Random.Range(10, 100); // General
        //print("2- " + val);
        //val = Random.Range(10, 100); // General
        //print("3- " + val);
        //val = Random.Range(10, 100); // General
        //print("4- " + val);
        //print("----------------------");
        //Random.InitState(12345);
        //val = Random.Range(10,100); // General
        //print("1- " + val);
        //val = Random.Range(10, 100); // General
        //print("2- " + val);
        //val = Random.Range(10, 100); // General
        //print("3- " + val);
        //val = Random.Range(10, 100); // General
        //print("4- " + val);
        //print("----------------------");
        //Random.InitState(12345);
        //val = Random.Range(10,100); // General
        //print("1- " + val);
        //val = Random.Range(10, 100); // General
        //print("2- " + val);
        //val = Random.Range(10, 100); // General
        //print(Random.Range(10, 100));
        //print("3- " + val);
        //val = Random.Range(10, 100); // General
        //print("4- " + val);
        //print("----------------------");
        //Random.InitState(12345);
        //val = Random.Range(10,100); // General
        //print("1- " + val);
        //val = Random.Range(10, 100); // General
        //print("2- " + val);
        //val = Random.Range(10, 100); // General
        //print("3- " + val);
        //val = Random.Range(10, 100); // General
        //print("4- " + val);


        System.Random rnd = new System.Random(12345);
        val = rnd.Next(10, 100);
        print("1- " + val);
        val = rnd.Next(10, 100);
        print("2- " + val);
        val = rnd.Next(10, 100);
        print("3- " + val);
        val = rnd.Next(10, 100);
        print("4- " + val);
        print("---------");
        rnd = new System.Random(12345);
        val = rnd.Next(10, 100);
        print("1- " + val);
        val = rnd.Next(10, 100);
        print("2- " + val);
        val = rnd.Next(10, 100);
        print("3- " + val);
        val = rnd.Next(10, 100);
        print("4- " + val);
        print("---------");
        rnd = new System.Random(12345);
        val = rnd.Next(10, 100);
        print("1- " + val);
        val = rnd.Next(10, 100);
        print(Random.Range(10,100));
        print("2- " + val);
        val = rnd.Next(10, 100);
        print("3- " + val);
        val = rnd.Next(10, 100);
        print("4- " + val);

        #endregion

        col.Shuffle();

        ///10 100
        /// Random. Range a mano
        int min = 10;
        int max = 100;
        float numero = min + Random.value * (max - min);


        if (Random.value < 0.20f)
        {
            //20 % probabilidad
        }

        //Random.ColorHSV();

        ///Random.insideUnitSphere;
        ///
        //Random.

    }

}
