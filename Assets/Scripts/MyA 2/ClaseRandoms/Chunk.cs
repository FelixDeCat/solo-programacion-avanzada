using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Chunk : MonoBehaviour, IPointerDownHandler
{
    public static Dictionary<int, Color> values;
    int chunkvalue = 0;

    private void Awake()
    {
        Initialize();
    }
    void Initialize()
    {
        if (values == null)
        {
            values = new Dictionary<int, Color>();
            values.Add(0, Color.white);
            values.Add(1, Color.grey);
            values.Add(2, Color.black);
            values.Add(3, Color.red);
            values.Add(4, Color.blue);
        }
    }

    public void SetValue(int val)
    {
        Initialize();
        chunkvalue = val;
        GetComponent<Renderer>().material.SetColor("_Color", values[chunkvalue]);
    }

    void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
    {
        chunkvalue++;
        if (chunkvalue >= values.Count)
        {
            chunkvalue = 0;
        }
        SetValue(chunkvalue);

        WorlGen.Instance.AddChange(new Vector2Int((int)transform.position.x, (int)transform.position.z), chunkvalue);
    }
}
