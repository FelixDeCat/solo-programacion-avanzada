using System.Collections.Generic;
using UnityEngine;

public class QuadTreeChunkManmager : MonoBehaviour
{
    public Transform player;
    public float activationRadius = 50f;
    public QuadTreeTerrain terrain;


    Rect viewBounds;

    HashSet<GameObject> _activeObject = new HashSet<GameObject>();

    void Update()
    {
        if (terrain == null || player == null) return;

        Vector2 size = Vector2.one * activationRadius;
        Vector2 posActive = new Vector2(player.position.x - size.x / 2, player.position.z - size.y / 2);

        viewBounds = new Rect(posActive, size);

        List<GameObject> visibles = terrain.Query(viewBounds);
        HashSet<GameObject> newVisibles = new HashSet<GameObject>(visibles);


        /// Comparo los viejops con los nuevos y apago los que no se ven en los nuevos
        foreach (var obj in _activeObject)
        {
            if (!newVisibles.Contains(obj))
            {
                obj.SetActive(false);
            }
        }

        ///comparo los nuevos, con los viejos, y si no estan en los viejos, los prendo
        foreach (var obj in visibles)
        {
            if (!_activeObject.Contains(obj))
            {
                obj.SetActive(true);
            }
        }

        _activeObject = newVisibles;

    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        DrawRect(viewBounds);
    }

    void DrawRect(Rect rect)
    {
        Vector3 dl = new Vector3(rect.x, 0, rect.y);
        Vector3 dr = new Vector3(rect.x + rect.width, 0, rect.y);
        Vector3 ul = new Vector3(rect.x, 0, rect.y + rect.height);
        Vector3 ur = new Vector3(rect.x + rect.width, 0, rect.y + rect.height);

        Gizmos.DrawLine(dl, dr);
        Gizmos.DrawLine(dr, ur);
        Gizmos.DrawLine(dl, ul);
        Gizmos.DrawLine(ul, ur);
    }
}
