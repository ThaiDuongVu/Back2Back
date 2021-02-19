using UnityEngine;

public class PlayerGunLaser : MonoBehaviour
{
    [SerializeField] private ProcessColor color;
    [SerializeField] private Player player;

    /// <summary>
    /// Unity Event function.
    /// Handle trigger collision.
    /// </summary>
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            Enemy enemy = other.GetComponent<Enemy>();

            // If correct color then destroy enemy
            if (color == enemy.color)
            {
                // Destroy enemy
                enemy.Die();

                // Add combo multiplier to player
                player.Combo.Add(1);
            }
            // If incorrect color then deal damage to player
            else
            {
                player.TakeDamage(10f);
            }

            // Shake camera
            CameraShaker.Instance.Shake(CameraShakeMode.Normal);
        }
    }
}
