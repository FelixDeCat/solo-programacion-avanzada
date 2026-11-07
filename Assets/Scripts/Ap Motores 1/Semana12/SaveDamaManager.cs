using System.IO;
using UnityEngine;

public class SaveDamaManager : MonoBehaviour
{
    [SerializeField] GameData data;

    string path;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        path = Path.Combine(Application.persistentDataPath, "SaveData.txt");

        Debug.Log(path);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            Save();
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            Load();
        }
    }

    void Save()
    {
        CheckIn();

        if (File.Exists(path))
        {
            string toSave = data.Name + "," + data.Level + "," + data.Currency;  /// "pepe,5,500"
            File.WriteAllText(path, toSave);
        }
    }
    void Load()
    {
        if (File.Exists(path))
        {
            string raw = File.ReadAllText(path);

            string[] col = raw.Split(',');

            data.SetName(col[0]);
            data.SetLevel(int.Parse(col[1]));  // int.Parse   "5" -> 5
            data.SetCurrency(float.Parse(col[2])); // float.Parse   "500" -> 500.0f

        }
        else
        {
            Debug.Log("El path No Existe");
            CheckIn();
        }
    }

    void CheckIn()
    {
        if (!File.Exists(path))
        {
            File.Create(path).Dispose(); /// File Access Violation Exception

            if (File.Exists(path))
            {
                Debug.Log("<color=green>El Path se creo Correctamente!!");
            }
        }
    }
}
