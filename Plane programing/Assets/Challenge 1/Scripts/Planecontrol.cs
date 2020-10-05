using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planecontrol : MonoBehaviour
{
//access modifier type name operator value
public float speed = .15F;
public float turnSpeed;


public float forwardInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
    forwardInput = Input.GetAxis("Vertical");
    // Move the vehicle forward based on forward input
    transform.Translate(Vector3.forward * speed);
    // Rotetes vehicle left and right based on horizontal input
    transform.Rotate(Vector3.right, turnSpeed * forwardInput * Time.deltaTime);
    }
}

