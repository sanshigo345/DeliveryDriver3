using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    // camera should be in same position as main car
    [SerializeField] GameObject thingToFollow;

    void LateUpdate()
    {
        transform.position = thingToFollow.transform.position + new Vector3(0, 0, -10);
    }
}
