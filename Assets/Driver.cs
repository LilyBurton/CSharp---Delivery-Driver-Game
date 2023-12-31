using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 1;
    [SerializeField] float moveSpeed = 0.01f;
    void Start()
    {
        
    }


    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed;
        float steerAccelerate = Input.GetAxis("Vertical") * moveSpeed;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, steerAccelerate, 0);
    }
}
