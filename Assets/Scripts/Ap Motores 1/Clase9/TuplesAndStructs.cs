using System;
using UnityEngine;

public class TuplesAndStructs : MonoBehaviour
{
    ParDeDatos datos1;
    PlayerData pdata;


    void Start()
    {
        pdata = new PlayerData("Jose".ToCharArray(), 20, "Arpistas".ToCharArray(), "Paladin".ToCharArray());

        // con clases, lo escribimos todo a mano
        var dataA = GetDataPair();
        print(dataA.data1);
        print(dataA.data2);

        // con clases, lo escribimos todo a mano
        //var dataB = GetDataPairT();
        //print(dataB.Item1);
        //print(dataB.Item2);


        // con clases, lo escribimos todo a mano
        var dataC = GetDataPairT<int, string>(20, "jose");
        print(dataC.Item1);
        print(dataC.Item2);


        Tuple<int, float, bool, char> myTuple = new Tuple<int, float, bool, char>(20, 20.5f, true, 't');

        print(myTuple.Item3); // true


    }

    void Update()
    {
        
    }

    public ParDeDatos GetData()
    {
        datos1.name = "jose";
        datos1.level = 2;
        return datos1;
    }


    public DataPair GetDataPair()
    {
        DataPair pair = new DataPair();
        pair.data1 = 20;
        pair.data2 = "Juan";
        return pair;
    }

    public Tuple<V1, V2> GetDataPairT<V1, V2>(V1 p1, V2 p2)
    {
        return new Tuple<V1, V2>(p1, p2);
    }


    public class DataPair
    {
        public int data1;
        public string data2;
    }
}


public struct ParDeDatos
{
    public string name;
    public int level;
}

public struct PlayerData
{
    char[] myname;
    int level;
    char[] faction;
    char[] heroclass;


    public PlayerData(char[] name, int level, char[] faction, char[] heroclass)
    {
        this.myname = name;
        this.level = level;
        this.faction = faction;
        this.heroclass = heroclass;
    }

    public char[] Myname { get => myname; }
    public int Level { get => level; }
    public char[] Faction { get => faction; }
    public char[] Heroclass { get => heroclass; }
}