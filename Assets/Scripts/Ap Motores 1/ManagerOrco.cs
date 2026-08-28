using UnityEngine;

public class ManagerOrco : MonoBehaviour
{
    public static ManagerOrco instance; /// NULO

    [SerializeField] Orco modelOrc;

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

    public Orco DameUnOrco(string name)
    {
        
        return GameObject.Instantiate(modelOrc);
    }

    
}
