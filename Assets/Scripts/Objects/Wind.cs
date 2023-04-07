using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wind : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.transform.tag == "Player")
        {
            print(1);
        }    
    }
}
