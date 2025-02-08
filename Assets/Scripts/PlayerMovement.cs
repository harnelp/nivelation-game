using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 20f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal"); // A (-1) | D (+1)
        float moveZ = Input.GetAxis("Vertical");   // W (+1) | S (-1)

        Vector3 movement = new Vector3(moveX, 0, moveZ) * speed;
        rb.velocity = new Vector3(movement.x, rb.velocity.y, movement.z);
    }
}
