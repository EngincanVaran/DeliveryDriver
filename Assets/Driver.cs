using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steeringSpeed = 200, moveSpeed = 15f, slowSpeed = 20f, fastSpeed = 30f;

    void Update()
    {
        float steeringAmount = Input.GetAxis("Horizontal") * steeringSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steeringAmount);
        transform.Translate(0, moveAmount, 0);
    }

    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        Debug.Log("Slowing down...");
        moveSpeed = slowSpeed;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Boost") {
            Debug.Log("Boosting...");
            moveSpeed = fastSpeed;
        }
    }
}
