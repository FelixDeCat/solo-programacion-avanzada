using System.IO;
using UnityEngine;

public class SaveDamaManagerConJSON : MonoBehaviour
{
    [SerializeField] GameData data;

    string path;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        path = Path.Combine(Application.persistentDataPath, "SaveDataJSON.json");

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
            string toSave = JsonUtility.ToJson(data, prettyPrint: true);
            File.WriteAllText(path, toSave);
        }
    }
    void Load()
    {
        if (File.Exists(path))
        {
            string raw = File.ReadAllText(path);

            data = JsonUtility.FromJson<GameData>(raw);

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
