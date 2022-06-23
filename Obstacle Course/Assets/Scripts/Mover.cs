using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    float xValue = 0f;
    float yValue = 0f;
    float zValue = 0f;

    private Rigidbody rb;
    private Vector3 moveDelta;

    [SerializeField] private float moveSpeed = 2f;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        xValue = Input.GetAxis("Horizontal");
        zValue = Input.GetAxis("Vertical");
        moveDelta.x = xValue;
        moveDelta.z = zValue;

        moveDelta = moveDelta.normalized * moveSpeed * Time.fixedDeltaTime;

        rb.AddForce(moveDelta * moveSpeed * Time.fixedDeltaTime);
        //rb.MovePosition(rb.position + moveDelta * moveSpeed * Time.fixedDeltaTime);
    }
}
