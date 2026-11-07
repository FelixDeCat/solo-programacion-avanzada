using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData
{
    [SerializeField] string name;
    [SerializeField] int level;
    [SerializeField] float currency;

    [SerializeField] List<MyObjectZaraza> myObject;

    public GameData(string name, int level, float currency)
    {
        this.name = name;
        this.level = level;
        this.currency = currency;
    }

    public string Name //lectura
    {
        get
        {
            return name;
        }
    }

    public int Level { get { return level; } }//lectura
    public float Currency { get => currency; }//lectura


    public void SetName(string _name) //escritura
    {
        name = _name;
    }
    public void SetLevel(int _level) //escritura
    {
        level = _level;
    }

    public void SetCurrency(float _currency) //escritura
    {
        currency = _currency;
    }
}


[System.Serializable]
public class MyObjectZaraza
{
    public int val1;
    public int va2;
    public int val4;
    public string other;
}
