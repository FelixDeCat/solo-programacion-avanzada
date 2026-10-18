using UnityEngine;
using System;

class OtraClase
{
    ClaseDelegados del;

    void AFUERA()
    {
       
        del.myaction = OtraFunc;
        del.myaction.Invoke();
        del.myaction += OtraFunc;

        //del.myactionEvent = OtraFunc;
        //del.myactionEvent.Invoke();
        del.myactionEvent += OtraFunc;
    }

    void OtraFunc()
    {

    }
}

public class ClaseDelegados : MonoBehaviour
{

    public Action myaction;
    public event Action myactionEvent;

    Action<int> myaction2;
    //Action<int, int> myaction2;

    ///   System. Action

    //Definicion
    delegate void MIDelegado();
    delegate void MIDelegadoParam(int asd);

    //Crear la Variable en memoria, donde voy a guardar las funciones
    MIDelegado miFuncion;

    Func<int, int, float> Calculator2;

    private delegate float Calculator(int A, int B);
    Calculator simple;

    [SerializeField] EnemyFinder waterEnemy;
    [SerializeField] EnemyFinder FlyingEnemy;
    [SerializeField] EnemyFinder zarazaEnemy;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        miFuncion = Juan;

        //el Inoke de "event" se puede hacer aca porque lo cree aca
        myactionEvent.Invoke();

        waterEnemy.SetCallbackSearch(BusquedaAcuatica);
        FlyingEnemy.SetCallbackSearch(BusquedaAerea);

        waterEnemy.ConfigureOnDeath(OnEnemyDeathInPosition);

        simple = SimpleCaclculationAAABBBPI;

        Calculator2 = SimpleCaclculationAAA;

        simple(3,6);
        simple(24,56);



    }

    public void ReciveAlgo(string val)
    {
        print("EL VALOR  ES: " + val);
    }

    bool OnEnemyDeathInPosition(Vector3 pos)
    {
        // spawn particula de splash de sangre, en pos
        print("ele enemigo murio en: " + pos);

        if (Vector3.Distance(transform.position, pos) < 5)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    float SimpleCaclculation(int AAA, int BBB)
    {
        return 2 + 2;
    }
    float SimpleCaclculationAAA(int AAA, int BBB)
    {
        return AAA + 2;
    }
    float SimpleCaclculationAAABBB(int AAA, int BBB)
    {
        return AAA + BBB;
    }
    float SimpleCaclculationAAABBBPI(int AAA, int BBB)
    {
        return AAA + BBB + (int)Mathf.PI;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            Pepe(); // puedo hacerlo acá  "ClaseDelegados"
        }

        if (Input.GetKeyDown(KeyCode.Y))
        {
            miFuncion(); // puedo hacerlo acá "ClaseDelegados", o puedo hacerlo en cualquier lado que tenga guardad la variable
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            waterEnemy.Hit(20);
        }

    }

    void BusquedaAcuatica()
    {
        print("Awa");
    }
    void BusquedaAerea()
    {
        print("Aire");
    }

    void Pepe()
    {
        print("Pepe");
    }
    void Juan()
    {
        print("Juan");
    }
}
