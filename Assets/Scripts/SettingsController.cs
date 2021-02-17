using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.PostProcessing;
using TMPro;

public class SettingsController : MonoBehaviour
{
    // Use a singleton pattern to make the class globally accessible
    #region Singleton

    private static SettingsController instance;

    public static SettingsController Instance
    {
        get
        {
            if (instance == null) instance = FindObjectOfType<SettingsController>();

            return instance;
        }
    }

    #endregion

    public Settings fullScreen;
    public Settings resolution;

    public Settings effects;
    [SerializeField] private PostProcessLayer postProcessLayer;

    public Settings antiAliasing;

    public Settings font;
    public TMP_FontAsset[] fonts;

    public new Settings audio;

    /// <summary>
    /// Unity Event function.
    /// Initialize before first frame update.
    /// </summary>
    private void Start()
    {
        Apply();
    }

    /// <summary>
    /// Apply current settings.
    /// </summary>
    public void Apply()
    {
        // Apply resolution & full screen settings
        Screen.SetResolution(resolution.currentState, resolution.currentState / 16 * 9,
            (FullScreenMode)fullScreen.currentState);

        // Apply effects setting
        postProcessLayer.enabled = effects.currentState == 1;

        // Apply anti-aliasing setting
        postProcessLayer.antialiasingMode = antiAliasing.currentState == 1 ? PostProcessLayer.Antialiasing.SubpixelMorphologicalAntialiasing : PostProcessLayer.Antialiasing.None;

        // Apply font setting
        foreach (Object o in Resources.FindObjectsOfTypeAll(typeof(TMP_Text)))
        {
            TMP_Text text = (TMP_Text)o;
            text.font = fonts[font.currentState];
        }

        // Apply audio setting
        foreach (Object o in Resources.FindObjectsOfTypeAll(typeof(AudioSource)))
        {
            AudioSource audioSource = (AudioSource)o;
            audioSource.enabled = false;
        }
    }
}