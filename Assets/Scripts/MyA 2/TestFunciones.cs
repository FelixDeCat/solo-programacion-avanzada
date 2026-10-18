using UnityEngine;

public class TestFunciones : MonoBehaviour
{
    int pepe = 20;
    int juan = 20;

    void Start()
    {

        //Func1();
        //pepe = 30;

        RecuFunc(5000);
    }


    public void Func1()
    {
        Debug.Log("Fun1");
        Func2();
        juan = 67;

    }

    public void Func2()
    {
        pepe = 40;

        Debug.Log("Fun2");
        Func3();
    }

    public void Func3()
    {
        juan = 34;
        Debug.Log("Fun3");
    }


    void RecuFunc(int watchDog)
    {
        print("Test: watchdog: " + watchDog);
        watchDog--;
        if (watchDog > 0) RecuFunc(watchDog);
        else return;
    }

    
}
