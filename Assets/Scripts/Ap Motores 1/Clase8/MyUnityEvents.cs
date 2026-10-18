using UnityEngine;
using UnityEngine.Events;

public class MyUnityEvents : MonoBehaviour
{
    [SerializeField] UnityEvent myEvent;

    [SerializeField] MyuEventString MyuEventString;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            myEvent.Invoke();

            MyuEventString.Invoke("PEPE");
        }

        
    }
}

[System.Serializable]
public class MyuEventString : UnityEvent<string>
{

}
