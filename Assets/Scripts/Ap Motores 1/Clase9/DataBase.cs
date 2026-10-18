using System.Collections.Generic;
using UnityEngine;

public class DataBase : MonoBehaviour
{
    public GameObject[] prefabs; /// 30 prefabs

    Dictionary<string, GameObject> cooked_prefabs;


    private void Start()
    {
        // prefabs[23] == guardo a rodolfo 


        for (int i = 0; i < prefabs.Length; i++)
        {
            if (cooked_prefabs.ContainsKey(prefabs[i].name))
            {
                cooked_prefabs.Add(prefabs[i].name, prefabs[i]);
            }
        }

        GetGameObjectByName("Rodolfo").SetActive(true);
    }


    public GameObject GetGameObjectByName(string param)
    {
        return cooked_prefabs[param];
    }
}
