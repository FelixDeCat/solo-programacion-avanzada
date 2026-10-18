using System;
using System.Collections.Generic;
using UnityEngine;

public class SourceTree : MonoBehaviour
{
    void Start()
    {
        Node<NodeInfo, float> richpath = new Node<NodeInfo, float>();
    }
}

public class NodeInfo
{

}


public class Node<T, W>
{

    Dictionary<string, Tuple<Node<T, W>, DataNode<T, W>>> transitions = new Dictionary<string, Tuple<Node<T, W>, DataNode<T, W>>>();

    public void RegisterNewNeighboor(string key, T nodeInfo, W weig)
    {

        //transitions.Add();
    }

}

public struct DataNode<T, W>
{
    T data;
    W weight;

    public DataNode(T data, W weight)
    {
        this.data = data;
        this.weight = weight;
    }

    public T Data { get => data; }
    public W Weight { get => weight; }
}

