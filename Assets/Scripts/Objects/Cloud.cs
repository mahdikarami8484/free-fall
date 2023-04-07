using System.Collections;
using UnityEngine;

public class Cloud : MonoBehaviour
{

    public float time = 5f;

    private GameObject player;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            player = other.gameObject;
            player.GetComponent<Move>().fallSpeed -= 1.2f;
            Invoke("SetFallSpeed", time);
        }        
    }

    void SetFallSpeed()
    {
        player.GetComponent<Move>().fallSpeed += 1.2f;
    }
}
