using UnityEngine;

public class Token : MonoBehaviour
{
    private Animator animator;

    /// <summary>
    /// Unity Event function.
    /// Get component references before first frame update.
    /// </summary>
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
}
