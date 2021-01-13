using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControl : MonoBehaviour
{
    private float forwardInput;
    private float turnInput;
    private float speed = 15; 
    private float turnSpeed = 150;
    private Animator playerAnim;

    // Start is called before the first frame update
    void Start()
    {
        playerAnim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        turnInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * forwardInput * speed);
        transform.Rotate(Vector3.up, turnSpeed * turnInput * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerAnim.SetBool("Sword_Swing", true);
        }
        else 
        {
            playerAnim.SetBool("Sword_Swing", false);
        }
    }
}
