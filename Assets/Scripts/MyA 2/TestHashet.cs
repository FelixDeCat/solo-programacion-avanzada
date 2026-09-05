using System.Collections.Generic;
using UnityEngine;

public class TestHashet : MonoBehaviour
{

    HashSet<string> uniqueCollection = new HashSet<string>();

    HashSet<string> contraseñas = new HashSet<string>();


    void Start()
    {
        /// hash = objeto.GetHashCode() => un codigo hexadecimal
        /// puede ser positivo o negativo
        /// hash = hash & 0x7FFFFFFF;
        /// hash &=  0x7FFFFFFF; /// lo hace positivo
        /// 


        uniqueCollection.Add("Jose");
        uniqueCollection.Add("Pedro");
        uniqueCollection.Add("Jose");


        

        /// { 0x12332353, 0x123452353 }
        /// 

        ///  passwords -> contraseña123
        ///  



        //// Guardamos una contraseña
        ///

        ///FRONT END del USUARIO
        ///
        string pass = "Pass123"; // UI

        int code = pass.GetHashCode();
        code = code & 0x7FFFFFFF;

        /// BACKEND SERVER
        contraseñas.Add(pass);




        ///FRONT END del USUARIO Otro usuario, otro front
        ///
        string passdeOtrousuario = "Pass123"; // UI 0x7FF34FFFF
        string passdeOtrousuario2 = "juandCarloZarzra"; // UI 0x7FF34FFF




        int code2 = pass.GetHashCode();
        code = code & 0x7FFFFFFF;


        if (contraseñas.Contains(passdeOtrousuario))
        {

        }



        ////Hash con posibilidad de guardar un valor -> HashTable != Diccionario
    }

    public class KeyVal
    {
        public string key;
        public object value;
    }


}
