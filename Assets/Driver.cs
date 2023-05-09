using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    //variables
    [SerializeField] float steerSpeed = 200;
    [SerializeField] float moveSpeed = 10;
    [SerializeField] float boostSpeed = 20;
    [SerializeField] float bumpSpeed = 5;
    

    // Will run every frame as the game is running
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0,0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == Tags.Boost.ToString())
        {
            moveSpeed = boostSpeed;
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.collider.tag == Tags.Bump.ToString())
        {
            moveSpeed = bumpSpeed;
        }
    }
}
