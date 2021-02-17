using UnityEngine;

public class MainCamera : MonoBehaviour
{
    public Transform followTarget;
    private float zOffset = -100f;

    private const float InterpolationRatio = 0.1f;

    /// <summary>
    /// Unity Event function.
    /// Update once per frame.
    /// </summary>
    private void Update()
    {
        Follow(followTarget);
    }

    /// <summary>
    /// Follow a target in game world.
    /// </summary>
    /// <param name="target">Target to follow</param>
    private void Follow(Transform target)
    {
        if (!target) return;

        Vector3 targetPosition = target.position;
        transform.position = Vector3.Lerp(transform.position, new Vector3(targetPosition.x, transform.position.y, targetPosition.z + zOffset), InterpolationRatio);
    }
}
