using System;
using System.Collections.Generic;
using UnityEngine;

public class GenericClasses : MonoBehaviour
{
    ProcessIntegers process1;
    ProcessString process3;

    private void Start()
    {
        process1 = new ProcessIntegers(2,2);
        int result = process1.AddToSequence(2);


        var process2 = new ProcessIntegers(3,(int)3.3f);
        int result2 = process2.AddToSequence((int)5.5f);

        process3 = new ProcessString("Hola", "Que");
        string result3 = process3.AddToSequence("Tal"); // HolaQueTal


        ProcessValue<int> processInt1 = new ProcessValue<int>(20,20);
        processInt1.SetCallbackInjection(SetMainOpetationBla);
        processInt1.AddToSequence(20); /// 0

        ProcessValue<string> processString1 = new ProcessValue<string>("Hola","Que");

        List<int> listas = new List<int>();

        print(this.GetFirstLetters()); // "Gen"

        DataPair<string, bool> nameCond = new DataPair<string, bool>("Pepe", true);

        print(nameCond.Val1);

    }


    public int SetMainOpetation(int a, int b, int c)
    {
        return a + b + c;
    }
    public int SetMainOpetationBla(int a, int b, int c)
    {
        return a - b * c + (int)Mathf.PI;
    }
}


public class ProcessIntegers
{
    int a;
    int b;

    public ProcessIntegers(int _a, int _b)
    {
        a = _a;
        b = _b;
    }
    public int AddToSequence(int c)
    {
        return a + b + c;
    }
}
public class ProcessString
{
    string a;
    string b;

    public ProcessString(string _a, string _b)
    {
        a = _a;
        b = _b;
    }
    public string AddToSequence(string c)
    {
        return a + b + c;
    }
}

public class ProcessValue<T>
{
    T a;
    T b;

    public ProcessValue(T _a, T _b)
    {
        a = _a;
        b = _b;
    }

    Func<T, T, T, T> operation;
    public void SetCallbackInjection(Func<T, T, T ,T> operation)
    {
        this.operation = operation;
    }

    public T AddToSequence(T c)
    {
        return operation.Invoke(a,b,c);
    }
}


public struct DataPair<V1, V2>
{
    V1 v1;
    V2 v2;

    public DataPair(V1 v1, V2 v2)
    {
        this.v1 = v1;
        this.v2 = v2;
    }

    public V1 Val1 { get => v1; }
    public V2 Val2 { get => v2; }
}


/// T Objects Constrains (where)
public class MonoProcessor<T> where T : MonoBehaviour
{
    public Transform GetObject(T objToFilter)
    {
        return objToFilter.GetComponent<Transform>();
    }
}

public static class GOExtensions
{
    public static string GetFirstLetters<T>(this T obj) where T : MonoBehaviour
    {
        char l1 = obj.gameObject.name[0];
        char l2 = obj.gameObject.name[1];
        char l3 = obj.gameObject.name[2];
        var msg = l1.ToString() + l2 + l3;
        return msg;
    }
}
