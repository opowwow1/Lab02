using UnityEngine;
using UnityEngine.InputSystem;

public class KeyControlledMover : MonoBehaviour
{
    public float moveSpeed = 3f;

    void Update()
    {
        if (Keyboard.current.eKey.isPressed)
        {
            float moveAmount = moveSpeed * Time.deltaTime;
            transform.Translate(moveAmount, 0, 0);
        }
    }
}