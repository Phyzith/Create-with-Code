using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float turnSpeed;
    public InputAction MoveAction;
    public Vector2 moveInput;

    void Start()
    {
        MoveAction.Enable();
    }

    void Update()
    {
        moveInput = MoveAction.ReadValue<Vector2>();

        transform.Translate(Vector3.forward * Time.deltaTime * speed * moveInput.y);
        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * moveInput.x);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * moveInput.x);
    }
}
