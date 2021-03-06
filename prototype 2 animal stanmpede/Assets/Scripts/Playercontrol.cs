﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontrol : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 15.0f;
    public float xRange = 19.0f;
    
    public GameObject foodProjectile;
    
    // Update is called once per frame
    void Update()
    {
        //movement for character left and right
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * horizontalInput * speed);
        //constrains players movement to the left
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        //contains players movement to the right
        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(foodProjectile, transform.position, foodProjectile.transform.rotation);
        }
    }
}
