using System.Collections.Generic;
using System.Net.Http;
using UnityEngine;
using static TemasVarios;

public class TemasVarios : MonoBehaviour
{
    private List<string> listaRemplazable = new List<string>(); // privado a nivel de clase
    IReadOnlyList<string> listaSoloLectura; //privado a nivel de escritura
    readonly List<string> listaNoRemplazable = new List<string>(); // privado a nivel de referencia (new prohibido)

    LinkedList<string> myStrings = new LinkedList<string>();

    LinkedList<Buff> buffs = new LinkedList<Buff>();

    public abstract class Buff
    {
        float duration;
        public abstract void DoEffect();
    }

    public class SpeedBuff : Buff
    {
        public override void DoEffect()
        {
            
        }
    }
    public class ForceBuff : Buff
    {
        public override void DoEffect()
        {
            
        }
    }

    void Start()
    {
       // SpeedBuff sp1 = new SpeedBuff();
       // SpeedBuff sp2 = new SpeedBuff();
       // SpeedBuff sp3 = new SpeedBuff();
       // SpeedBuff sp4 = new SpeedBuff();
       // ForceBuff f1 = new ForceBuff();
       // ForceBuff f2 = new ForceBuff();
       // ForceBuff f3 = new ForceBuff();
       // ForceBuff f4 = new ForceBuff();

       // buffs.AddToFirst(sp1);
       // buffs.AddToFirst(sp2);
       // buffs.AddToFirst(sp3);
       // buffs.AddToFirst(sp4);
       // buffs.AddToFirst(f1);
       // buffs.AddToFirst(f2);
       // buffs.AddToFirst(f3);
       // buffs.AddToFirst(f4);

       // sp1.DoEffect();
       // buffs.RemoveFromFirst(sp1);

       // sp2.DoEffect();
       // buffs.RemoveFromFirst(sp2);


       // myStrings.AddToLast("Pepe");
       // myStrings.AddToLast("Juan");
       // myStrings.AddToFirst("maria");
       // myStrings.AddToLast("lucas");

       // foreach (var b in buffs)
       // {
       //     b.DoEffect();
       //     buffs.RemoveFromFirst(b);
       // }

       // //maria pepe juan lucas

       // myStrings.RemoveFromFirst("maria");

       // //pepe juan lucas


       // listaRemplazable = new List<string>();
       // listaRemplazable.Add("20");
       // listaRemplazable.Add("34");
       // listaRemplazable.Add("50");
       // listaRemplazable.Add("76");

       // listaSoloLectura = listaRemplazable;

       //// listaNoRemplazable = new List<string>(); /// Justamente no me deja hacerle NEW porque es readonly
       // listaNoRemplazable.Add("20");
       // listaNoRemplazable.Add("20");

       // //NormalParametrized(20,30,40);
       // //NormalParametrized(20,30,40,50);
       // //NormalParametrized(20,true,40,50);


       // //NormalParametrized(20, 30, 40, 50);
       // //NormalParametrized(20, 30);
       // //NormalParametrized(20);

       // //SumaParametrizada(20);  //(20,1,"defaultName")
       // //SumaParametrizada(20, 30);  //(20,30,"defaultName")
       // //SumaParametrizada(20, 30, "Pepe");  //(20,30,"Pepe")


       // //int[] col = new int[3];
       // //col[0] = 10;
       // //col[1] = 20;
       // //col[2] = 30;

       // //FuncionParametrizadaPOrColeccion(col);
       // //FuncionParametrizadaPorColeccionParams2(10,20,30);

       // //myObject obj1 = new myObject(20,"pepe");
       // //myObject obj2 = new myObject(24,"juan");
       // //myObject obj3 = new myObject(43,"maria");

       // //FuncionConVariosObjetos(
       // //    obj1,
       // //    obj2,
       // //    obj3, 
       // //    new myObject(68, "karla"),
       // //    new myObject(24, "tulio")
       // //    );

       // /// COPIA
       // int val1 = 20;
       // Sum1(val1);
       // print(val1); /// 20

       // // OUT ORIGINAL, pero lo tengo que llenar si o si
       // int val2 = 20;
       // Sum2(out val2);
       // print(val2); /// 30

       // Sum4(out int val4); // Me permite crear la variable en el lugar
       // print(val4); /// 30

       // // REF ORIGINAL, llenarlo es opcional
       // int val3 = 20;
       // Sum3(ref val3);
       // print(val3); /// 30

       // int val5 = 40;
       // Sum5(ref val5); // NO Me permite crear la variable en el lugar
       // print(val5); /// 30




        myObject obj1 = new myObject(23,"jose");
        obj1.myList = new List<int>();
        obj1.myList.Add(1);
        print(obj1.myList[0]); // 1


        myObject obj2 = new myObject();
        obj2.myList = new List<int>();
        //// Externamente
        ///
        ///// NO conozco lo que viene del otro lado

        try
        {
            obj2.myList.Add(1); /// 
            print(obj2.myList[5]);
        }
        catch (System.NullReferenceException ex)
        {
            print("La lista Interna no fue creada, y me tiraria un null reference Exception");
        }
        catch (System.ArgumentOutOfRangeException ex)
        {
            Debug.LogError("el objeto es: " + obj2.myList);
            print("No tenes el 5° indice, indice fuera de rango");
            print("mas informacion en: " + ex.Message);
        }


        /// [serializacion]
        ///  "12,34,pepe,true"
        ///  "12,34,pepe,true"
        ///  "invalid,34,pepe,true"
        ///  "12,34,pepe,true"
        ///  

        string valueToINt = "invalid";
        int newVal = 0;
        try
        {
            newVal = int.Parse(valueToINt);
        }
        catch (System.FormatException cast)
        {
            Debug.Log("Mercado me dio el parametro de Usuario Eliminado");
            newVal = -1;
        }
        

        if (newVal > 0)
        {
            //solo usarios Válidos
        }
        
        





        // 1

    }





    void Sum1(int val) // pasar una variable por copia -- copia de 20
    {
        val = 30;
    }
    void Sum2(out int val) //  pasando variable por referencia -- estoy usando la variable original
    {
        val = 40;
    }
    void Sum3(ref int val) //  pasando variable por referencia -- estoy usando la variable original
    {
        //val = 60;
    }
    void Sum4(out int val) 
    {
        val = 60;
    }
    void Sum5(ref int val)
    {
        //val = 60;
    }









    /// SOBRECARGA de FUNCIONES
    void NormalParametrized(int val1, int val2, int val3)
    {

    }
    //void NormalParametrized(int val1, int val2, int val3, int val4)
    //{

    //}
    void NormalParametrized(int val1, bool val2, int val3, int val4)
    {

    }

    ///Parametros Opcionales, Dinamicos o flexibles
    void NormalParametrized(int val1, int val2 = 0, int val3 = 20, int val4 = 30)
    {

    }

    void SumaParametrizada(int A, int B = 1, string name = "defaultName")
    {

    }

     
    void FuncionParametrizadaPOrColeccion(int[] myNumbers)
    {
        for (int i = 0; i < myNumbers.Length; i++)
        {
            print("num: " + myNumbers[i].ToString());
        }
    }

    /// Parametros con params -> me genera un array
    void FuncionParametrizadaPorColeccionParams2(params int[] myNumbers)
    {
        for (int i = 0; i < myNumbers.Length; i++)
        {
            print("num: " + myNumbers[i].ToString());
        }
    }

    void FuncionConVariosObjetos(params myObject[] objs)
    {
        for (int i = 0; i < objs.Length; i++)
        {
            print($"OBJ {objs[i].id} ::: {objs[i].name}");
        }
    }

    public class myObject
    {
        public int id;
        public string name;
        public List<int> myList;

        public myObject()
        {

        }

        public myObject(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }


}
