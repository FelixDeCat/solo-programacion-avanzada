using System.Collections.Generic;
using UnityEngine;

public class MyHashTable<K,V>
{
    List<KeyValuePair<K,V>>[] _data;

    public MyHashTable(int capacity) // 20
    {
        _data = new List<KeyValuePair<K, V>>[capacity];

        for (int i = 0; i < _data.Length; i++)
        {
            _data[i] = new List<KeyValuePair<K, V>>();
        }
    }

    public V Get(K key)
    {
        int index = GetIndex(key);
        var col = _data[index];

        if (ContainsKey(key))
        {
            foreach (var kv in col)
            {
                if (kv.Key.Equals(key))
                {
                    return kv.Value;
                }
            }

        }

        return default;
    }

    public void Add(K key, V val)
    {
        int index = GetIndex(key);
        var col = _data[index];

        var keyVal = new KeyValuePair<K, V>(key, val);

        if (ContainsKey(key))
        {
            Debug.Log("Llave repetida");
        }
        else
        {
            _data[index].Add(keyVal);
        }
    }
    public void Remove(K key)
    {
        int index = GetIndex(key);
        var col = _data[index];

        for (int i = col.Count - 1; i >= 0; i--)
        {
            if (col[i].Key.Equals(key))
            {
                col.RemoveAt(i);
                break;
            }
        }
    }
    public void Modify(K key, V val)
    {
        int index = GetIndex(key);
        var col = _data[index];

        var keyVal = new KeyValuePair<K, V>(key, val);


        if (ContainsKey(key))
        {
            _data[index].Add(keyVal);
        }
    }

    public bool ContainsKey(K key)
    {
        int index = GetIndex(key);
        var col = _data[index];

        foreach (var kv in col)
        {
            if (kv.Key.Equals(key))
            {
                return true;
            }
        }

        return false;
    }


    int GetIndex(K key)
    {
        int code = key.GetHashCode();
        code = Mathf.Abs(code);
        return code % _data.Length;
    }
}


