using UnityEngine;

public class MarkovRoom : MonoBehaviour
{

    // [0] left
    // [1] up
    // [2] down
    // [3] right

    public Transform[] doors;

    public void OpenDoor(int index)
    {
        if (doors[index] != null)
        {
            doors[index].gameObject.SetActive(false);
        }
    }
}
