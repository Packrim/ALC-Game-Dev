using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontrol : MonoBehaviour
{
//access modifier type name operator value
private int speed = 15;
public float turnSpeed;

private float horizontalInput;
private float forwardInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    horizontalInput = Input.GetAxis("Horizontal");
    forwardInput = Input.GetAxis("Vertical");
    // Move the vehicle forward based on forward input
    transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
    // Rotetes vehicle left and right based on horizontal input
    transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
    }
}
