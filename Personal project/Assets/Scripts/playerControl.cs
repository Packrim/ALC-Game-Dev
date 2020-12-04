using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControl : MonoBehaviour
{
    private float forwardInput;
    private float turnInput;
    private float speed = 10; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        turnInput = Input.GetAxis("Horizontal");
        forwardInput = forwardInput.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * forwardInput * speed);
        tramsform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * speed);
    }
}
