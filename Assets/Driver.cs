using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
        transform.Rotate(0, 0, 0.01f);
        transform.Translate(0.001f, 0, 0);
    }
}
