using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject thingToFollow;
    // this things position (camera) will be the same with the car

    void LateUpdate()
    {
        transform.position = thingToFollow.transform.position + new Vector3 (0, 0, -12);
    }
}
