using UnityEngine;

public class PlayerGunLaser : MonoBehaviour
{
    [SerializeField] private ProcessColor color;
    [SerializeField] private Player player;

    private float currentScale;
    private const float InterpolationRatio = 0.2f;

    /// <summary>
    /// Unity Event function.
    /// Initialize before first frame update.
    /// </summary>
    private void Start()
    {
        Scale(Player.NormalLaserScale);
    }

    /// <summary>
    /// Unity Event function.
    /// Update once per frame.
    /// </summary>
    private void Update()
    {
        transform.localScale = Vector3.Lerp(transform.localScale, new Vector3(transform.localScale.x, transform.localScale.y, currentScale), InterpolationRatio);
    }

    /// <summary>
    /// Unity Event function.
    /// Handle trigger collision.
    /// </summary>
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            Enemy enemy = other.GetComponent<Enemy>();
            if (enemy.IsDead) return;

            // If correct color then destroy enemy
            if (color == enemy.color)
            {
                // Add combo multiplier to player
                player.Combo.Add(1);
                // Add player score
                player.AddScore(1);
            }
            // If incorrect color then deal damage to player
            else
            {
                player.TakeDamage(10f);
            }

            // Destroy enemy
            enemy.Die();
            // Shake camera
            CameraShaker.Instance.Shake(CameraShakeMode.Normal);
        }
    }

    /// <summary>
    /// Scale laser.
    /// </summary>
    /// <param name="newScale">Scale to set</param>
    public void Scale(float newScale)
    {
        currentScale = newScale;
    }
}
