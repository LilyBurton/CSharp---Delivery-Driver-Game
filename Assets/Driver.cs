using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 1;
    [SerializeField] float moveSpeed = 20f;

    [SerializeField] float slowSpeed = 15f;

    [SerializeField] float boostSpeed = 30f;

    BoxCollider2D boxCollider;
   
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float steerAccelerate = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, steerAccelerate, 0);
    }

    void OnCollisionEnter2D(Collision2D other) {

            moveSpeed = slowSpeed;
    }
    void OnTriggerEnter2D(Collider2D other) {

        if (other.tag == "boost") {
            Debug.Log("Got to go fast!");
            moveSpeed = boostSpeed;
        }
    }
}
