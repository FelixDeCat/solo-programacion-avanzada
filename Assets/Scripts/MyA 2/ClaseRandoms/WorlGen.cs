
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class WorlGen : MonoBehaviour
{
    public static WorlGen Instance;

    public int scale = 50;

    [SerializeField] Chunk model;

    public int elevation = 10;

    public int offset = -2;

    SaveData<WorldData> saveData;

    Dictionary<Vector2Int, WorldChange> changes = new Dictionary<Vector2Int, WorldChange>();

    [SerializeField] WorldData world;

    private void Awake()
    {
        Instance = this;

        saveData = new SaveData<WorldData>("World1", "txt");

        UIHandler.OnGenButtonPressed += Gen;
        UIHandler.OnSaveButtonPressed += Save;
        UIHandler.OnLoadButtonPressed += Load;
    }

    void Gen()
    {
        int seed = world.seed;
        float[,] noise = RandomTools.GenerateNoiseMap(scale,scale, seed);

        int min = 0;
        int max = 3;


        System.Random rnd = new System.Random(seed);
        for (int x = 0; x < scale; x++)
        {
            for (int z = 0; z < scale; z++)
            {
                int val = rnd.Next(min, max);

                var chunk = Instantiate(model);
                chunk.transform.position = new Vector3(x, (noise[x, z] + offset) * elevation, z);
                chunk.transform.SetParent(transform);

                if (changes.ContainsKey(new Vector2Int(x, z)))
                {
                    int persval = changes[new Vector2Int(x, z)].value;
                    chunk.SetValue(persval);
                }
                else
                {
                    chunk.SetValue(val);
                }
                // obj x, noise[x,z] , z
            }
        }
    }
    public void AddChange(Vector2Int coord, int val)
    {
        WorldChange dato = new WorldChange();
        dato.coord = coord;
        dato.value = val;

        if (changes.ContainsKey(coord))
        {
            changes[coord] = dato;
        }
        else
        {
            changes.Add(coord, dato);
        }
    }

    void Save()
    {
        world.changes = changes.Values.ToList();
        saveData.OnSave(world);
    }
    void Load()
    {
        world = saveData.OnLoad();

        foreach (var change in world.changes)
        {
            var persistent = new WorldChange();
            persistent.value = change.value;
            persistent.coord = change.coord;

            if (changes.ContainsKey(change.coord))
            {
                changes[change.coord] = persistent;
            }
            else
            {
                changes.Add(change.coord, persistent);
            }
        }
    }
}

[System.Serializable]
public struct WorldData
{
    public string name;
    public int seed;
    public List<WorldChange> changes;
}

[System.Serializable]
public struct WorldChange
{
    public Vector2Int coord;
    public int value;
}
