using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private Player player;

    private Vector3 movement;
    private Vector3 direction;
    private float currentVelocity;

    private const float MaxVelocity = 30f;
    private const float MinVelocity = 0f;
    private const float Acceleration = 60f;
    private const float Deceleration = 30f;

    private float lookVelocity;
    private float lookScale = 0.05f;
    private float lookSensitivity = 2f;

    private new Camera camera;
    private MainCamera mainCamera;

    private InputManager inputManager;

    /// <summary>
    /// Unity Event function.
    /// Initialize input handler on object enabled.
    /// </summary>
    private void OnEnable()
    {
        inputManager = new InputManager();

        // Handle movement keyboard input
        inputManager.Player.MoveKeyboard.performed += MoveOnPerformed;
        inputManager.Player.MoveKeyboard.canceled += MoveOnCanceled;

        // Handle movement gamepad input
        inputManager.Player.MoveGamepad.performed += MoveOnPerformed;
        inputManager.Player.MoveGamepad.canceled += MoveOnCanceled;

        // Look rotation
        inputManager.Player.Look.performed += LookOnPerformed;
        inputManager.Player.Look.canceled += LookOnCanceled;

        inputManager.Enable();
    }

    #region Input Methods

    /// <summary>
    /// On move input performed.
    /// </summary>
    /// <param name="context">Input context</param>
    private void MoveOnPerformed(InputAction.CallbackContext context)
    {
        // Debug.Log(context.control.device == InputSystem.devices[0]);

        // If player is in a middle of a dash then return
        if (Time.timeScale == 0f || !player.IsControllable) return;

        // Set movement vector
        Vector2 contextVector = context.ReadValue<Vector2>();
        direction = new Vector3(contextVector.x, 0f, contextVector.y);

        // Play walk animation
        foreach (PlayerCharacter character in player.characters)
            character.StartWalking();

        player.IsWalking = true;
    }

    /// <summary>
    /// On move input canceled.
    /// </summary>
    /// <param name="context">Input context</param>
    private void MoveOnCanceled(InputAction.CallbackContext context)
    {
        if (Time.timeScale == 0f) return;

        // Reset movement vector
        direction = Vector2.zero;

        // Stop walk animation
        foreach (PlayerCharacter character in player.characters)
            character.StopWalking();

        player.IsWalking = false;
    }

    /// <summary>
    /// On look input performed.
    /// </summary>
    /// <param name="context">Input context</param>
    private void LookOnPerformed(InputAction.CallbackContext context)
    {
        if (!player.IsControllable) return;

        lookVelocity = context.ReadValue<Vector2>().x;
    }

    /// <summary>
    /// On look input canceled.
    /// </summary>
    /// <param name="context">Input context</param>
    private void LookOnCanceled(InputAction.CallbackContext context)
    {
        lookVelocity = 0f;
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
        player = GetComponent<Player>();

        camera = Camera.main;
        if (camera is { }) mainCamera = camera.GetComponent<MainCamera>();

        lookVelocity = -lookScale;
    }

    /// <summary>
    /// Unity Event function.
    /// Update at consistent time.
    /// </summary>
    private void FixedUpdate()
    {
        if (Time.timeScale == 0f || player.IsDead) return;

        // If player is walking then accelerate
        if (player.IsWalking) Accelerate();
        // If not then decelerate
        else Decelerate();

        // If player is walking then walk
        if (player.IsWalking) Walk();

        Rotate();
    }

    /// <summary>
    /// Unity Event function.
    /// Update once per frame.
    /// </summary>
    private void Update()
    {
        if (Time.timeScale == 0f || player.IsDead) return;

        Animate();
    }

    /// <summary>
    /// Move player to movement vector.
    /// </summary>
    private void Walk()
    {
        // movement = Quaternion.Euler(0f, 0f, camera.transform.eulerAngles.z) * direction;
        player.Rigidbody.MovePosition(player.Rigidbody.position + direction * (currentVelocity * Time.fixedDeltaTime));
    }

    /// <summary>
    /// Accelerate if current velocity is less than max velocity.
    /// </summary>
    private void Accelerate()
    {
        if (currentVelocity < MaxVelocity) currentVelocity += Acceleration * Time.deltaTime;
    }

    /// <summary>
    /// Decelerate if current velocity is greater than min velocity.
    /// </summary>
    private void Decelerate()
    {
        if (currentVelocity > MinVelocity) currentVelocity -= Deceleration * Time.deltaTime;
        // If player near stopping then stop
        if (Mathf.Abs(currentVelocity - MinVelocity) < 0.1f) StopMovement();
    }

    /// <summary>
    /// Stop walking.
    /// </summary>
    public void StopMovement()
    {
        currentVelocity = 0f;
        direction = Vector2.zero;
    }

    /// <summary>
    /// Rotate to look velocity.
    /// </summary>
    private void Rotate()
    {
        lookVelocity = Mathf.Clamp(lookVelocity, -3f, 3f);
        player.Rigidbody.MoveRotation(transform.rotation * Quaternion.Euler(new Vector3(0f, -(lookVelocity + lookScale) * lookSensitivity * Time.timeScale, 0f)));
    }

    /// <summary>
    /// Stop looking.
    /// </summary>
    public void StopRotation()
    {
        lookVelocity = 0f;
    }

    /// <summary>
    /// Scale animation speed to movement speed.
    /// </summary>
    private void Animate()
    {
        // If player is not walking then set animation speed to 1
        if (!player.IsWalking)
        {
            foreach (PlayerCharacter character in player.characters)
                character.Animate(1f);

            return;
        }

        // If not then set animation speed to velocity length
        foreach (PlayerCharacter character in player.characters)
            character.Animate(currentVelocity / MaxVelocity);
    }
}
