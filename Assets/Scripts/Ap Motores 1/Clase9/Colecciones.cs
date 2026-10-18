using System;
using System.Collections.Generic;
using UnityEngine;

public class Colecciones : MonoBehaviour
{




    Dictionary<int, string> biblioteca;

    Dictionary<string, Vector3> positions = new Dictionary<string, Vector3>();

    Dictionary<string, Action<string>> commands = new Dictionary<string, Action<string>>();

    void Start()
    {
        biblioteca = new Dictionary<int, string>();

        biblioteca.Add(500, "Cocina");
        biblioteca.Add(6, "Manuales de Rol");
        biblioteca.Add(3, "Terror");
        biblioteca.Add(2, "Romanticas");

        commands.Add("spawnbox", SpawnRedBox);
       


        foreach (var item in biblioteca) // recorremos keyvaluepair (un par de Llave-Valor)
        {
            // si yo quiero el valor: item.Value
            // si yo quiero la llave: item.Key
        }

        foreach (var item in biblioteca.Values) // solo valores
        {

        }
        foreach (var item in biblioteca.Keys)  //solo llaves
        {

        }

        print(biblioteca[2]); //Romanticas

        for (int i = 0; i < biblioteca.Count; i++)
        {
            print(biblioteca[i]);
        }

        if (biblioteca.ContainsKey(3))
        {
            /// tengo el sector de terror
        }


        // forma clásica
        if (!biblioteca.ContainsKey(4))
        {
            biblioteca.Add(4, "Policiales");
        }

        // forma mas moderna
        if (biblioteca.TryGetValue(4, out string name))
        {
            name = "policiales";
            biblioteca[4] = name;
        }

        positions.Add("Enfermeria", new Vector3(34f,0,67f));
        positions.Add("Herreria", new Vector3(0,0,10f));


        print("La enfermeria esta en la posicion: " + positions["Enfermeria"].x + " : " + positions["Enfermeria"].z);


        /// Look Up Table /// algoritmo de Optimizacion de Datos (Cocina de datos, bake de datos)

        commands["spawnbox"]("red");
        string comandExterno = "sv_spawnbox_red";
        string[] allvals = comandExterno.Split('_');  /// 0 sv   1 spawnbox   2 red

        ExceuteCommand(allvals[1], allvals[2]);

    }

    public void ExceuteCommand(string comand, string parameter)
    {
        commands[comand](parameter);
    }


   private void SpawnRedBox(string parameter)
    {
        

        var box = GameObject.CreatePrimitive(PrimitiveType.Cube);
        if (parameter == "red") box.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
    }



}
