using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
    private Animator animator;
    [SerializeField] private ParticleSystem trail;

    [SerializeField] private Rigidbody[] bodyParts;

    /// <summary>
    /// Unity Event function.
    /// Get component references before first frame update.
    /// </summary>
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    /// <summary>
    /// Character starts walking.
    /// </summary>
    public void StartWalking()
    {
        animator.SetBool("isWalking", true);
        trail.Play();
    }

    /// <summary>
    /// Character stops walking.
    /// </summary>
    public void StopWalking()
    {
        animator.SetBool("isWalking", false);
        trail.Stop();
    }

    /// <summary>
    /// Set character animation speed.
    /// </summary>
    /// <param name="speed">Speed to set</param>
    public void Animate(float speed)
    {
        animator.speed = speed;
    }

    /// <summary>
    /// Enable character body ragdoll.
    /// </summary>    
    public void EnableRagdoll()
    {
        // Disable animation
        animator.enabled = false;

        // Enable each body part physics
        foreach (Rigidbody part in bodyParts)
        {
            part.isKinematic = false;
            part.useGravity = true;

            // Add a *little* force upwards
            part.AddForce((Vector3.up + new Vector3(Random.Range(0f, 0.2f), 0f, Random.Range(0f, 0.2f))) * 10f, ForceMode.Impulse);
        }

        // Remove character from player
        transform.parent = null;
    }
}
