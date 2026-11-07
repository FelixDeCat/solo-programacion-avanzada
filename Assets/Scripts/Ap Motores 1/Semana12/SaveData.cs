using System.IO;
using UnityEngine;

public class SaveDataGen<T>
{
    string path;

    public SaveDataGen(string archive, string ext = "txt")
    {
        path = Path.Combine(Application.persistentDataPath, archive + "." + ext);
    }

    public void Save(T _data)
    {
        CheckIn();

        if (File.Exists(path))
        {
            string toSave = JsonUtility.ToJson(_data, prettyPrint: true);
            File.WriteAllText(path, toSave);
        }
    }
    public T Load()
    {
        if (File.Exists(path))
        {
            string raw = File.ReadAllText(path);

            var dat = JsonUtility.FromJson<T>(raw);

            return dat;

        }
        else
        {
            Debug.Log("El path No Existe");
            CheckIn();

            return default(T); /// un objeto definido anteriormente como default
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
