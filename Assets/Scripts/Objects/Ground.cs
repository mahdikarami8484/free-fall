using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.transform.tag == "Player")
        {
            Time.timeScale = 0;
        }
    }
}
