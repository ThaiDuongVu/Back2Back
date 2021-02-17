using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public PlayerMovement Movement { get; set; }

    public const float MaxHealth = 10f;
    public float CurrentHealth { get; set; }

    public bool IsControllable { get; set; } = true;
    public bool IsWalking { get; set; }

    public List<PlayerCharacter> characters;

    /// <summary>
    /// Unity Event function.
    /// Get component references.
    /// </summary>
    private void Awake()
    {
        Movement = GetComponent<PlayerMovement>();
    }

    /// <summary>
    /// Unity Event function.
    /// Initialize before first frame update.
    /// </summary>
    private void Start()
    {

    }

    /// <summary>
    /// Unity Event function.
    /// Update once per frame.
    /// </summary>
    private void Update()
    {

    }
}
