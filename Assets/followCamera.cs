using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followCamera : MonoBehaviour
{
    [SerializeField] GameObject carToFollow;
    // position of the camera should be the same as the car's position

    void LateUpdate()
    {
        transform.position = carToFollow.transform.position + new Vector3 (0,0,-10);
    }
}
