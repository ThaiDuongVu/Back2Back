using UnityEngine;

public class Token : MonoBehaviour
{
    private Animator animator;
    [SerializeField] private FeedbackText feedbackText;

    [SerializeField] private ParticleSystem yellowExplosion;

    /// <summary>
    /// Unity Event function.
    /// Get component references.
    /// </summary>
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    /// <summary>
    /// On token collected.
    /// </summary>
    public void OnCollected()
    {
        // Provide feedback
        Instantiate(feedbackText, transform.position, feedbackText.transform.rotation);

        // Destroy token
        Instantiate(yellowExplosion, transform.position, yellowExplosion.transform.rotation);
        Destroy(gameObject);
    }
}
