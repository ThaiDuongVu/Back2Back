using UnityEngine;

public class Pursuer : Enemy
{
    private const float Speed = 5f;

    /// <summary>
    /// Unity Event function.
    /// Initialize before first frame update.
    /// </summary>
    private void Start()
    {
        SetProcessColor();
    }

    /// <summary>
    /// Unity Event function.
    /// Update once per frame.
    /// </summary>
    private void FixedUpdate()
    {
        if (!isDead) Pursue(player.transform);
    }

    /// <summary>
    /// Move to a target transform.
    /// </summary>
    /// <param name="target">Target to move to</param>
    private void Pursue(Transform target)
    {
        // Look at target
        transform.LookAt(target);
        // Move forward
        rigidbody.MovePosition(rigidbody.position + transform.forward * (Speed * Time.fixedDeltaTime));
    }
}
