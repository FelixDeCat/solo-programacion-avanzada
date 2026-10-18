using System;
using UnityEngine;

public class EnemyFinder : MonoBehaviour
{

    public delegate void SearchCBK();
    SearchCBK searchCBK;

    public void SetCallbackSearch(SearchCBK injectionMode)
    {
        searchCBK = injectionMode;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            Search();
        }
    }

    public void Search()
    {
        // Injection

        searchCBK();
    }

    Func<Vector3, bool> onDeath;

    public void ConfigureOnDeath(Func<Vector3, bool> _onDeath)
    {
        onDeath = _onDeath;
    }

    int life = 100;
    public void Hit(int dmg)
    {
        life -= dmg;

        if (life < 0)
        {
            life = 0;

            /// aca avisamos que nos morimos, y pasamos la posicion
            if (onDeath.Invoke(transform.position))
            {
                print("exploto");
            }
        }
    }
}
