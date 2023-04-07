using UnityEngine;

public class Blade : MonoBehaviour
{

    public float speed = 3f;
    
    private Camera main;

    void Start()
    {
        main = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
    }

    void Update()
    {
        if(transform.position.x >= Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 0f, 0f)).x)
        {
            speed = -speed;
        }
        if(transform.position.x <= -Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 0f, 0f)).x){
            speed = -speed;
        }
        transform.position += transform.right * Time.deltaTime * speed;
    }

    void ChangeDirection()
    {
        speed = -speed;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.transform.tag == "Player")
        {
            Vector3 contactPoint = other.contacts[0].point;
            Vector3 center = other.collider.bounds.center;
            if(contactPoint.y < center.y)
            {
                Time.timeScale = 0;
            }
        }
    }
}
