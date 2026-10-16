using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float slowestSpeed;
    public float rotationSpeed;
    public float verticalInput;
    public float horizontalInput;
    private float origSpeed;

    // Start is called before the first frame update
    void Start()
    {
        origSpeed = speed;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * Time.deltaTime * speed); 

        // tilt the plane up/down based on up/down analog input and arrow keys
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime * verticalInput);

        // speed the plane up/down based on the analog input and arrow keys
        speed = (origSpeed * horizontalInput) + origSpeed + slowestSpeed;

        Debug.Log($"H: {horizontalInput:F2}  V: {verticalInput:F2}");
    }
}
