using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectCollision : MonoBehaviour
{
    
    void OnTriggerEnter(Collider other)
    {
    //Destroy this object
        Destroy(gameObject);
    //Destroy the other object it collides with
        Destroy(other.gameObject);
    }
}
