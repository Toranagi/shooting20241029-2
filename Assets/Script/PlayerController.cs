using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 0/5f;
    public float rotatespeed = 0.5f;
    private Animator

    Vector3 direction;

    float snappedHorizontal;
    float snappedVertical;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
    }

   void Move(float v)
    {
        if(v!=0)
        {
            direction = transform.TransformDirection(new Vector3(0f, 0f, v));

            direction *= speed;

            direction *= Time.deltaTime;

            transform.position += direction;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
