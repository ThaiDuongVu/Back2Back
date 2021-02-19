using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    // Use a singleton pattern to make the class globally accessible
    #region Singleton

    private static GameController instance;

    public static GameController Instance
    {
        get
        {
            if (instance == null) instance = FindObjectOfType<GameController>();

            return instance;
        }
    }

    #endregion

    public GameState State { get; set; } = GameState.Started;

    [SerializeField] private Menu pauseMenu;
    [SerializeField] private Menu gameOverMenu;
    [SerializeField] private Menu[] otherMenus;

    [SerializeField] private PostProcessProfile postProcessProfile;
    private DepthOfField depthOfField;

    [SerializeField] private Player player;
    [SerializeField] private Image playerHealthBar;

    [SerializeField] private Enemy[] enemyPrefabs;
    private float enemySpawnTimer;
    private float enemySpawnTimerMax;

    private InputManager inputManager;

    /// <summary>
    /// Unity Event function.
    /// Initialize input handler on object enabled.
    /// </summary>
    private void OnEnable()
    {
        inputManager = new InputManager();
        inputManager.Game.Escape.performed += EscapeOnPerformed;
        inputManager.Enable();
    }

    #region Input Methods

    /// <summary>
    /// On escape input performed.
    /// </summary>
    /// <param name="context">Input context</param>
    private void EscapeOnPerformed(InputAction.CallbackContext context)
    {
        if (State == GameState.Started)
            Pause();
        else if (State == GameState.Paused)
            Resume();
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
    /// Initialize before first frame update.
    /// </summary>
    private void Start()
    {
        postProcessProfile.TryGetSettings(out depthOfField);

        Application.targetFrameRate = Screen.currentResolution.refreshRate;
        DisableCursor();

        SetDepthOfField(false);

        ResetEnemySpawnTimer();
    }

    /// <summary>
    /// Unity Event function.
    /// Update once per frame.
    /// </summary>
    private void Update()
    {
        UpdatePlayerHealthBar();

        // Spawn a new enemy on timer ends
        if (EnemySpawnTimer())
        {
            SpawnEnemy();
            ResetEnemySpawnTimer();
        }
    }

    /// <summary>
    /// Disable current mouse cursor.
    /// </summary>
    public void DisableCursor()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    /// <summary>
    /// Enable current mouse cursor.
    /// </summary>
    public void EnableCursor()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    /// <summary>
    /// Enable/disable depth of field effect.
    /// </summary>
    /// <param name="value">Enable state</param>
    public void SetDepthOfField(bool value)
    {
        depthOfField.enabled.value = value;
    }

    /// <summary>
    /// Pause current game.
    /// </summary>
    public void Pause()
    {
        // Update game state
        State = GameState.Paused;

        // Enable depth of field effect
        SetDepthOfField(true);

        // Enable pause menu
        pauseMenu.SetEnabled(true);
        // Freeze game
        Time.timeScale = 0f;

        EnableCursor();
    }

    /// <summary>
    /// Resume current game.
    /// </summary>
    public void Resume()
    {
        // Update game state
        State = GameState.Started;

        // Disable depth of field effect
        SetDepthOfField(false);

        // Disable menus
        pauseMenu.SetEnabled(false);
        pauseMenu.SetInteractable(true);

        foreach (Menu menu in otherMenus)
        {
            menu.SetEnabled(false);
            menu.SetInteractable(true);
        }

        // Unfreeze game
        Time.timeScale = 1f;

        DisableCursor();
    }

    /// <summary>
    /// Handle game over.
    /// </summary>
    public void GameOver()
    {
        // Update game state
        State = GameState.Over;

        // Enable depth of field effect
        SetDepthOfField(true);

        // Enable pause menu
        gameOverMenu.SetEnabled(true);

        EnableCursor();
    }

    /// <summary>
    /// Update health bar to reflect current health.
    /// </summary>
    private void UpdatePlayerHealthBar()
    {
        playerHealthBar.transform.localScale = Vector3.Lerp(playerHealthBar.transform.localScale, new Vector3(player.CurrentHealth / Player.MaxHealth, 1f, 1f), 0.1f);
    }

    /// <summary>
    /// Spawn enemy regularly.
    /// </summary>
    private void SpawnEnemy()
    {
        // Enemy init position
        Vector3 spawnPosition = player.transform.position + new Vector3(Random.Range(-50f, 50f), 0f, Random.Range(-50f, 50f));
        // Enemy init rotation
        Quaternion spawRotation = Quaternion.identity;

        Instantiate(enemyPrefabs[Random.Range(0, enemyPrefabs.Length)], spawnPosition, spawRotation);
    }

    /// <summary>
    /// Timer to spawn next enemy.
    /// </summary>
    private bool EnemySpawnTimer()
    {
        if (!player.IsDead) enemySpawnTimer += Time.deltaTime;
        return enemySpawnTimer >= enemySpawnTimerMax;
    }

    /// <summary>
    /// Reset timer to spawn next enemy.
    /// </summary>
    private void ResetEnemySpawnTimer()
    {
        enemySpawnTimer = 0f;
        enemySpawnTimerMax = Random.Range(1f, 2f);
    }
}
