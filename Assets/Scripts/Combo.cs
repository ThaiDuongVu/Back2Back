using UnityEngine;
using TMPro;

public class Combo : MonoBehaviour
{
    public int multiplier;
    private float timer;
    private const float TimerMax = 5f;

    [SerializeField] private TMP_Text text;
    private RectTransform textTransform;

    /// <summary>
    /// Unity Event function.
    /// Get component references.
    /// </summary>
    private void Awake()
    {
        textTransform = text.GetComponent<RectTransform>();
    }

    /// <summary>
    /// Unity Event function.
    /// Update once per frame.
    /// </summary>
    private void Update()
    {
        if (timer > 0f)
            timer -= Time.deltaTime;
        else if (timer <= 0f)
            Cancel();

        textTransform.localScale = new Vector2(1f, 1f) * (timer / TimerMax);
    }

    /// <summary>
    /// Add combo multiplier.
    /// </summary>
    /// <param name="amount">Amount to multiply</param>
    public void Add(int amount)
    {
        multiplier += amount;
        timer = TimerMax;

        textTransform.localRotation = new Quaternion(0f, 0f, Random.Range(-0.25f, 0.25f), 1f);
        text.text = "x" + multiplier.ToString();
    }

    /// <summary>
    /// Cancel current combo.
    /// </summary>
    public void Cancel()
    {
        multiplier = 0;
        timer = 0f;
    }
}
