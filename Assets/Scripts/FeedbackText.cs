using System.Collections;
using UnityEngine;

public class FeedbackText : MonoBehaviour
{
    /// <summary>
    /// Unity Event function.
    /// Initialize before first frame update.
    /// </summary>
    private void Start()
    {
        StartCoroutine(DestroyDelay());
    }

    /// <summary>
    /// Destroy text after a delay.
    /// </summary>
    private IEnumerator DestroyDelay()
    {
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }
}
