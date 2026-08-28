using UnityEngine;

public class ManagerSoldados : MonoBehaviour
{
    public static ManagerSoldados instance; /// NULO

    void Start()
    {
        if (instance == null) // soy el primero, me tengo que coronar
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else //  si habia un rey, me pego el corchazo
        {
            Destroy(this.gameObject);

            /// PARA EDITORES
            // DestroyImmediate(instance);
        }
        
    }

    public MarineWH DameUnMarine(string name)
    {
        MarineWH marine = new MarineWH(name);
        print("*el marine grita!!!" + MarineWH.credo);
        return marine;
    }

    
}
