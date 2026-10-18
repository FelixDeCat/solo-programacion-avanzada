using UnityEngine;

public abstract class EnemyBase : MonoBehaviour
{
    public void FollowPlayer()
    {
        /// bool seguir
    }

    private void Update()
    {
        /// si bool seguir
        ///     perseguir
        ///     //
        ///     /
        ///     /
        ///     /
        ///     /
        ///     cuando termina de seguir al player, lo alcance
        ///     OnReachTarget(elPlayer);
    }

    public abstract void OnReachPlayer(Transform target);
}
