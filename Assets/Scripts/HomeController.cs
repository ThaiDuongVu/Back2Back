using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class HomeController : MonoBehaviour
{
    [SerializeField] private PostProcessProfile postProcessProfile;
    private DepthOfField depthOfField;

    /// <summary>
    /// Unity Event function.
    /// Initialize before first frame update.
    /// </summary>
    private void Start()
    {
        postProcessProfile.TryGetSettings(out depthOfField);
    }

    /// <summary>
    /// Enable/disable depth of field effect.
    /// </summary>
    /// <param name="value">Enable state</param>
    public void SetDepthOfField(bool value)
    {
        depthOfField.enabled.value = value;
    }
}
