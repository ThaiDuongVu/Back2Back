using UnityEngine;

public class Pursuer : Enemy
{
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
    private void Update()
    {
        if (!isDead) Pursue(player.transform);
    }

    /// <summary>
    /// Move to a target transform.
    /// </summary>
    /// <param name="target">Target to move to</param>
    private void Pursue(Transform target)
    {
        transform.LookAt(target);
    }
}
