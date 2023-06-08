using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steeringSpeed = 1, moveSpeed = 0.01f;

    void Start()
    {

    }

    void Update()
    {
        float steeringAmount = Input.GetAxis("Horizontal") * steeringSpeed;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed;
        transform.Rotate(0, 0, -steeringAmount);
        transform.Translate(0, moveAmount, 0);
    }
}
