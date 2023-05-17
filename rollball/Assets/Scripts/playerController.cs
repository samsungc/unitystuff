using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;


public class playerController : MonoBehaviour
{
    public float speeeeed = 0;
    public TextMeshProUGUI score;
    public GameObject winner;
    private Rigidbody rb;
    private int count;
    private float movementx;
    private float movementy;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;

        setScore();
        winner.gameObject.SetActive(false);
    }

    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();
        movementx = movementVector.x;
        movementy = movementVector.y;

    }

    void setScore()
    {
        score.text = "SCORE: " + count.ToString();

        if (count >= 12){
            winner.gameObject.SetActive(true);
        }
    }

    void FixedUpdate()
    {
        Vector3 movementVector = new Vector3(movementx, 0.0f, movementy);
        rb.AddForce(movementVector * speeeeed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pickup"))
        {
            other.gameObject.SetActive(false);
        }

        count += 1;
        setScore();
    }

}
