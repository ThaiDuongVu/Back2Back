using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class Player : MonoBehaviour
{
    public PlayerMovement Movement { get; private set; }
    public Combo Combo { get; private set; }
    public Rigidbody Rigidbody { get; private set; }

    public const float MaxHealth = 100f;
    public float CurrentHealth { get; set; }

    public bool IsControllable { get; set; } = true;
    public bool IsWalking { get; set; }

    public bool IsDead { get; private set; }

    public List<PlayerCharacter> characters;

    /// <summary>
    /// Unity Event function.
    /// Get component references.
    /// </summary>
    private void Awake()
    {
        Movement = GetComponent<PlayerMovement>();
        Combo = GetComponent<Combo>();
        Rigidbody = GetComponent<Rigidbody>();
    }

    /// <summary>
    /// Unity Event function.
    /// Initialize before first frame update.
    /// </summary>
    private void Start()
    {
        CurrentHealth = MaxHealth;
    }

    /// <summary>
    /// Unity Event function.
    /// Update once per frame.
    /// </summary>
    private void Update()
    {

    }

    /// <summary>
    /// Deal damage to player.
    /// </summary>
    /// <param name="damage">Damage to deal</param>
    public void TakeDamage(float damage)
    {
        // Decrease current health
        CurrentHealth -= damage;

        // If current health is to low then die
        if (CurrentHealth <= 0)
            Die();
    }

    /// <summary>
    /// Player dead.
    /// </summary>
    public void Die()
    {
        IsDead = true;

        // Enable all character ragdolls
        foreach (PlayerCharacter character in characters)
            character.EnableRagdoll();

        // Kill all enemies
        foreach (Enemy enemy in FindObjectsOfType<Enemy>())
            enemy.Die();

        // Transition to game over state
        GameController.Instance.GameOver();
    }
}
