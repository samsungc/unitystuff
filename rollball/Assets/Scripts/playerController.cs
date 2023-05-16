using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class playerController : MonoBehaviour
{
    public float speeeeed = 0

    private Rigidbody rb;
    private float movementx;
    private float movementy;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();
        movementx = movementVector.x;
        movementy = movementVector.y;

    }

    void FixedUpdate()
    {
        Vector3 movementVector = new Vector3(movementx, 0.0f, movementy);
        rb.AddForce(movementVector * speeeeed);
    }

}
