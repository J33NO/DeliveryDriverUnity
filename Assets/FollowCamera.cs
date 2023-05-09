using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    //This things position (camera) should match that of the car
    [SerializeField]
    GameObject thingToFollow;

    // Update is called once per frame
    void LateUpdate()
    {
        var cameraOffset = new Vector3(0, 0, -10);
        transform.position = thingToFollow.transform.position + cameraOffset;
    }
}
