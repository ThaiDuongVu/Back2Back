using UnityEngine;

public class PlayerGunLaser : MonoBehaviour
{
    [SerializeField] private ProcessColor color;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            Enemy enemy = other.GetComponent<Enemy>();

            // If correct color then destroy enemy
            if (color == enemy.color)
            {
                // Enable enemy ragdoll
                enemy.EnableRagdoll();
                // Destroy enemy

                enemy.Die();
                // Shake camera
                CameraShaker.Instance.Shake(CameraShakeMode.Normal);
            }
            // If incorrect color then deal damage to player
            else
            {

            }
        }
    }
}
