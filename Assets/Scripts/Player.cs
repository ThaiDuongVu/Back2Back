using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class Player : MonoBehaviour
{
    public PlayerMovement Movement { get; private set; }
    public PlayerGunLaser[] Lasers;
    public Combo Combo { get; private set; }
    public Rigidbody Rigidbody { get; private set; }

    public int Score { get; private set; }
    public int HighScore { get; private set; }
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private TMP_Text highScoreText;
    [SerializeField] private TMP_Text newHighScoreText;

    public const float MaxHealth = 100f;
    public float CurrentHealth { get; set; }

    public bool IsControllable { get; set; } = true;
    public bool IsWalking { get; set; }

    public bool IsDead { get; private set; }

    public List<PlayerCharacter> characters;

    public const float NormalLaserScale = 7.5f;
    public const float ShortLaserScale = 2.5f;
    public const float LongLaserScale = 15f;
    private Animator cameraAnimator;

    [SerializeField] private ParticleSystem yellowExplosion;

    private InputManager inputManager;

    /// <summary>
    /// Unity Event function.
    /// Initialize input handler on object enabled.
    /// </summary>
    private void OnEnable()
    {
        inputManager = new InputManager();

        inputManager.Player.ShrinkLaser.started += ShrinkLaserOnStarted;
        inputManager.Player.ExpandLaser.started += ExpandLaserOnStarted;

        inputManager.Player.ShrinkLaser.canceled += ShrinkExpandLaserOnCanceled;
        inputManager.Player.ExpandLaser.canceled += ShrinkExpandLaserOnCanceled;

        inputManager.Enable();
    }

    #region Input Methods

    /// <summary>
    /// On shrink laser input started.
    /// </summary>
    /// <param name="context">Input context</param>
    private void ShrinkLaserOnStarted(InputAction.CallbackContext context)
    {
        if (IsDead) return;

        foreach (PlayerGunLaser laser in Lasers)
            laser.Scale(ShortLaserScale);

        cameraAnimator.SetBool("zoomIn", true);
    }

    /// <summary>
    /// On expand laser input started.
    /// </summary>
    /// <param name="context">Input context</param>
    private void ExpandLaserOnStarted(InputAction.CallbackContext context)
    {
        if (IsDead) return;

        foreach (PlayerGunLaser laser in Lasers)
            laser.Scale(LongLaserScale);

        cameraAnimator.SetBool("panOut", true);
    }

    /// <summary>
    /// On shrink/expand laser input canceled.
    /// </summary>
    /// <param name="context">Input context</param>
    private void ShrinkExpandLaserOnCanceled(InputAction.CallbackContext context)
    {
        if (IsDead) return;

        foreach (PlayerGunLaser laser in Lasers)
            laser.Scale(NormalLaserScale);

        cameraAnimator.SetBool("zoomIn", false);
        cameraAnimator.SetBool("panOut", false);
    }

    #endregion

    /// <summary>
    /// Unity Event function.
    /// Disable input handling on object disabled.
    /// </summary>
    private void OnDisable()
    {
        inputManager.Disable();
    }

    /// <summary>
    /// Unity Event function.
    /// Get component references.
    /// </summary>
    private void Awake()
    {
        Movement = GetComponent<PlayerMovement>();
        Combo = GetComponent<Combo>();
        Rigidbody = GetComponent<Rigidbody>();
        cameraAnimator = Camera.main.GetComponent<Animator>();

        HighScore = PlayerPrefs.GetInt("HighScore", 0);
        highScoreText.text = "High Score: " + HighScore.ToString();
        newHighScoreText.gameObject.SetActive(false);
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

    /// <summary>
    /// Add player score.
    /// </summary>
    /// <param name="score">Score to add</param>
    public void AddScore(int score)
    {
        Score += score * Combo.multiplier;
        CheckNewHighScore();

        // Update score text
        scoreText.text = Score.ToString();
    }

    /// <summary>
    /// Check for high score.
    /// </summary>
    private void CheckNewHighScore()
    {
        if (Score <= HighScore) return;

        HighScore = Score;

        newHighScoreText.gameObject.SetActive(true);
        highScoreText.text = "High Score: " + HighScore.ToString();

        PlayerPrefs.SetInt("HighScore", HighScore);
    }

    /// <summary>
    /// Collect token on trigger enter.
    /// </summary>
    public void CollectToken(Token token)
    {
        // Add token score
        AddScore(10);

        // Destroy token
        Instantiate(yellowExplosion, token.transform.position, yellowExplosion.transform.rotation);
        Destroy(token.gameObject);
    }

    /// <summary>
    /// Unity Event function.
    /// Handle trigger collision.
    /// </summary>
    private void OnTriggerEnter(Collider other)
    {
        if (IsDead) return;

        if (other.CompareTag("Enemy"))
        {
            Enemy enemy = other.GetComponent<Enemy>();
            // Deal damage
            TakeDamage(enemy.damage);
        }
        else if (other.CompareTag("Token"))
        {
            CollectToken(other.GetComponent<Token>());
        }
        else if (other.CompareTag("Border"))
        {
            Die();
        }
        else if (other.CompareTag("LevelNext"))
        {
            LevelGenerator.Instance.GenerateNext();
            other.gameObject.SetActive(false);
        }

        // Shake camera
        CameraShaker.Instance.Shake(CameraShakeMode.Normal);
    }
}
