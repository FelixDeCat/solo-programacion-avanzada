using System.Collections.Generic;
using UnityEngine;

public class QuadTreeTerrain : MonoBehaviour
{

    public int depth = 4;
    public Rect rectRootNode;
    public GameObject terrainModel;

    [SerializeField] QuadTreeNode root;

    private void Start()
    {
        root = new QuadTreeNode(rectRootNode);

        GenerateTerrain(parent: root, currentDepth: depth);
    }

    void GenerateTerrain(QuadTreeNode parent, int currentDepth)
    {
        Vector3 modelPos = new Vector3(parent.bounds.x, 0, parent.bounds.y);

        /// El nodo que me pasan es el que genero
        parent.terrain = Instantiate(terrainModel, modelPos, Quaternion.identity);
        parent.terrain.SetActive(false);

        if (currentDepth <= 0) return;

        /// despues subdivido si es necesario
        parent.Subdivide();
        foreach (var child in parent.children)
        {
            GenerateTerrain(child, currentDepth - 1);
        }
    }

    public List<GameObject> Query(Rect area)
    {
        List<GameObject> result = new List<GameObject>();

        Query(root, area, result);

        return result;

    }

    void Query(QuadTreeNode node, Rect area, List<GameObject> results)
    {

        if (!node.bounds.Overlaps(area)) return;

        if (node.IsLeaf)
        {
            results.Add(node.terrain);
        }
        else
        {
            foreach (var child in node.children)
            {
                Query(child, area, results);
            }
        }
    }

    private void OnDrawGizmos()
    {
        if (root == null) return;
        if (root.children == null) return;

        RecuDraw(root, depth);

        Gizmos.color = Color.white;
        DrawRect(root.bounds);
    }

    void RecuDraw(QuadTreeNode node, int currentDepth)
    {
        Gizmos.color = Color.yellow;

        DrawRect(node.bounds);

        if (currentDepth <= 0) return;

        foreach (var c in node.children)
        {
            RecuDraw(c, currentDepth -1);
        }
    }


    void DrawRect(Rect rect)
    {
        Vector3 dl = new Vector3(rect.x,                0,  rect.y);
        Vector3 dr = new Vector3(rect.x + rect.width,   0,  rect.y);
        Vector3 ul = new Vector3(rect.x,                0,  rect.y + rect.height);
        Vector3 ur = new Vector3(rect.x + rect.width,   0,  rect.y + rect.height);

        Gizmos.DrawLine(dl, dr);
        Gizmos.DrawLine(dr, ur);
        Gizmos.DrawLine(dl, ul);
        Gizmos.DrawLine(ul, ur);
    }
}
