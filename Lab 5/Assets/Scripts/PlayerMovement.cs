
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _speed = 5f;

    private void Update()
    {
        Keyboard keyboard = Keyboard.current;

        if (keyboard == null)
            return;

        Vector3 movement = Vector3.zero;

        // Read WASD using the New Input System.
        if (keyboard.wKey.isPressed)
            movement.z += 1f;

        if (keyboard.sKey.isPressed)
            movement.z -= 1f;

        if (keyboard.aKey.isPressed)
            movement.x -= 1f;

        if (keyboard.dKey.isPressed)
            movement.x += 1f;

        // Prevent diagonal movement from being faster.
        movement = movement.normalized;

        // Move the player in world space.
        transform.position += movement * _speed * Time.deltaTime;
    }
}

