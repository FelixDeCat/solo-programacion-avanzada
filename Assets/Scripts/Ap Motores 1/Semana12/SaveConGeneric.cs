using System.IO;
using UnityEngine;

public class SaveConGeneric : MonoBehaviour
{
    [SerializeField] GameData data;
    [SerializeField] Info myInfo;

    SaveDataGen<GameData> saveObject;
    SaveDataGen<Info> saveInfo;

    void Start()
    {
        saveObject = new SaveDataGen<GameData>("SaveGen","gen");
        saveInfo = new SaveDataGen<Info>("GameInfo", "info");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            saveObject.Save(data);

            myInfo = new Info() { deviceID = 23, nameID = "Android" };
            saveInfo.Save(myInfo);
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            data = saveObject.Load();
            myInfo = saveInfo.Load();
        }
    }
}

[System.Serializable]
public struct Info
{
    public int deviceID;
    public string nameID;
}
