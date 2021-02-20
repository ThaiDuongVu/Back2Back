using System.Collections;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float damage;

    [HideInInspector] public ProcessColor color;
    private int colorIndex;

    // 0: Blue
    // 1: Red
    [SerializeField] private Material[] coloredMaterials;
    [SerializeField] private MeshRenderer[] coloredBodyParts;

    [SerializeField] private MeshRenderer[] deadBodyParts;
    [SerializeField] private Material deadMaterial;

    public bool IsDead { get; private set; }

    private Animator animator;
    [SerializeField] private Rigidbody[] bodyParts;
    private BoxCollider[] bodyColliders;

    [SerializeField] private ParticleSystem blueExplosion;
    [SerializeField] private ParticleSystem redExplosion;

    protected Player player;
    protected new Rigidbody rigidbody;

    [SerializeField] private FeedbackText feedbackText;

    /// <summary>
    /// Unity Event function.
    /// Get component references before first frame update.
    /// </summary>
    private void Awake()
    {
        animator = GetComponent<Animator>();

        player = FindObjectOfType<Player>();
        rigidbody = GetComponent<Rigidbody>();

        bodyColliders = new BoxCollider[bodyParts.Length];
        for (int i = 0; i < bodyColliders.Length; i++)
            bodyColliders[i] = bodyParts[i].GetComponent<BoxCollider>();
    }

    /// <summary>
    /// Set enemy process color.
    /// </summary>
    public void SetProcessColor()
    {
        // Choose a color from process color enum
        colorIndex = Random.Range(0, 2);
        color = (colorIndex == 0) ? ProcessColor.Blue : ProcessColor.Red;

        // Change body color
        foreach (MeshRenderer part in coloredBodyParts)
            part.material = coloredMaterials[colorIndex];
    }

    /// <summary>
    /// Enable character body ragdoll.
    /// </summary>    
    public void EnableRagdoll()
    {
        // Disable animation
        animator.enabled = false;

        // Enable body colliders
        foreach (BoxCollider collider in bodyColliders)
            collider.enabled = true;

        // Enable body physics
        foreach (Rigidbody part in bodyParts)
        {
            part.isKinematic = false;
            part.useGravity = true;

            // Add a *little* force upwards
            part.AddForce((Vector3.up + new Vector3(Random.Range(0f, 0.2f), 0f, Random.Range(0f, 0.2f))) * 10f, ForceMode.Impulse);
        }

        // Spawn appropriate explosion
        if (color == ProcessColor.Blue)
            Instantiate(blueExplosion, transform.position, transform.rotation);
        else if (color == ProcessColor.Red)
            Instantiate(redExplosion, transform.position, transform.rotation);
    }

    /// <summary>
    /// Die with a delay.
    /// </summary>
    private IEnumerator StartDying()
    {
        yield return new WaitForSeconds(3f);
        Destroy(gameObject);
    }

    /// <summary>
    /// Destroy enemy.
    /// </summary>
    public void Die()
    {
        // Update death state
        IsDead = true;
        // Enter ragdoll mode
        EnableRagdoll();

        // Provide feedback
        Instantiate(feedbackText, transform.position, feedbackText.transform.rotation);

        foreach (MeshRenderer part in deadBodyParts)
            part.material = deadMaterial;

        StartCoroutine(StartDying());
    }
}
