using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float turnSpeed = 0.5f;
    [SerializeField] float moveSpeed = 0.1f;

    [SerializeField] float slowSpeed = 5f;
    [SerializeField] float boostSpeed = 20f;

    void Start()
    {
        
    }

    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;

        transform.Rotate(0, 0, -steerAmount);

        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        transform.Translate(0, moveAmount, 0);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Boost"))
        {
            moveSpeed = boostSpeed;
            Destroy(other.gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        moveSpeed = slowSpeed;
    }
}
