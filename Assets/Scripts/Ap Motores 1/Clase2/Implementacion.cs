using MyEntities;
using MyEntities.Core;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Implementacion : MonoBehaviour
{


    void Start()
    {
        Perro perro; // Definicion

        // Escribiendo en perro un perro nuevo en memoria
        perro = new Perro(); // 4 patas

        perro = new Perro(3); // perro personalizado de 3 patas

        perro.Alimentar(1);
        perro.Alimentar(1);
        perro.Alimentar(1);
        perro.Alimentar(1);

        perro.nombre = "Raul";

        perro.Amputar(2);


        var marine = ManagerSoldados.instance.DameUnMarine("Juan");

        var orco = ManagerOrco.instance.DameUnOrco("Lucas");

    
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            SceneManager.LoadScene(1);
        }
    }
}
