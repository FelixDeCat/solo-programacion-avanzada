using System.IO;
using UnityEngine;

public class SaveData<T>
{
    string path = string.Empty;
    public SaveData(string dataName, string extension = "txt")
    {
        this.path = Path.Combine(Application.persistentDataPath, dataName + "." + extension);
        CreatePathIfNotExist();
    }

    public bool HasDataInPath()
    {
        T data = default(T);
        if (File.Exists(path))
        {
            string rawdata = File.ReadAllText(path);
            data = JsonUtility.FromJson<T>(rawdata);
            return data != null;
        }
        return false;
    }

    public T OnLoad()
    {
        T data = default(T);

        if (File.Exists(path))
        {
            string rawdata = File.ReadAllText(path);

            data = JsonUtility.FromJson<T>(rawdata);
        }
        else
        {
            CreatePathIfNotExist();
        }

        return data;

    }

    public void OnSave(T _save)
    {
        string data = JsonUtility.ToJson(_save);

        CreatePathIfNotExist();

        if (File.Exists(path))
        {
            File.WriteAllText(path, data);
        }
    }

    void CreatePathIfNotExist()
    {
        if (!File.Exists(path))
        {
            File.Create(path).Dispose();
            Debug.Log("<color=green>Se creó: " + path + " exitosamente</color>");
        }
    }
}
