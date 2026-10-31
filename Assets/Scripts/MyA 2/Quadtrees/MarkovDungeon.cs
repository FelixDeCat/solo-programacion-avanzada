using System.Collections.Generic;
using UnityEngine;

public class MarkovDungeon : MonoBehaviour
{

    public MarkovRoom roomPrefab;
    public int roomCount = 10;
    public int roomSize = 5;

    [Range(0f, 1f)]
    public float straightChance = 0.6f;

    Vector2Int[] directions = { Vector2Int.left, Vector2Int.up, Vector2Int.down, Vector2Int.right };

    List<Vector2Int> positions = new List<Vector2Int>();


    private void Start()
    {
        Generate();
    }

    void Generate()
    {
        /// Semilla
        /// 
        Vector2Int position = Vector2Int.zero;
        int dirIndex = Random.Range(0,4);
        MarkovRoom current = CreateRoom(position);
        positions.Add(position);

        for (int i = 0; i < roomCount; i++)
        {
            if (Random.value > straightChance)
            {
                dirIndex = Random.Range(0, 4);
            }

            Vector2Int nextPos = position + directions[dirIndex];

            if (positions.Contains(nextPos))
            {
                continue;
            }

            MarkovRoom nextRoom = CreateRoom(nextPos);

            current.OpenDoor(dirIndex);
            nextRoom.OpenDoor(3 - dirIndex);

            positions.Add(nextPos);

            position = nextPos;
            current = nextRoom;

        }


    }

    MarkovRoom CreateRoom(Vector2Int postion)
    {
        Vector3 worldPos = new Vector3(postion.x * roomSize, 0, postion.y * roomSize);

        return Instantiate(roomPrefab, worldPos, Quaternion.identity);
    }


}
