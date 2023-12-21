using System.Collections.Generic;
using UnityEngine;

public class FirstPersonMovement : MonoBehaviour
{
    public float speed = 5;

    [Header("Running")]
    public bool canRun = true;
    public bool IsRunning { get; private set; }
    public float runSpeed = 9;
    public KeyCode runningKey = KeyCode.LeftShift;

    private Rigidbody rigidbody;
    private bool isPaused = false;

    public List<System.Func<float>> speedOverrides = new List<System.Func<float>>();

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        // Check for pause input (for example, the "Escape" key)
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePause();
        }
    }

    private void FixedUpdate()
    {
        // If the game is paused, don't update the movement
        if (isPaused)
        {
            return;
        }

        IsRunning = canRun && Input.GetKey(runningKey);

        float targetMovingSpeed = IsRunning ? runSpeed : speed;
        if (speedOverrides.Count > 0)
        {
            targetMovingSpeed = speedOverrides[speedOverrides.Count - 1]();
        }

        Vector2 targetVelocity = new Vector2(Input.GetAxis("Horizontal") * targetMovingSpeed, Input.GetAxis("Vertical") * targetMovingSpeed);

        rigidbody.velocity = transform.rotation * new Vector3(targetVelocity.x, rigidbody.velocity.y, targetVelocity.y);
    }

    private void TogglePause()
    {
        if (isPaused)
        {
            // Resume the game
            Time.timeScale = 1.0f;
        }
        else
        {
            // Pause the game
            Time.timeScale = 0.0f;
        }

        // Toggle the pause state
        isPaused = !isPaused;
    }
}
