using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planecontrol : MonoBehaviour
{
//access modifier type name operator value
  
   
   
  
   public float forwardInput;
   
    // Update is called once per frame
    void Update()
    {
        
        //move vehical forward
        transform.Translate(Vector3.forward);
   
    }
}
