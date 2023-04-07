using UnityEngine;

public class GameController : MonoBehaviour
{
    private GameInputs gameInputs;

    public GameObject airplane;
    public GameObject player;

    private float fallSpeed;

    void Awake()
    {
        gameInputs = new GameInputs();    
    }

    void OnEnable()
    {
        gameInputs.Enable();
    }

    void OnDisable()
    {
        gameInputs.Disable();
    }

    void Start()
    {
        player.GetComponent<Move>().enabled = false;
        Time.timeScale = 1;
        fallSpeed = player.GetComponent<Move>().fallSpeed;
    } 

    void Update()
    {
        if(airplane != null && airplane.transform.position.x > 0f && airplane.transform.childCount > 0)
        {
            Time.timeScale = 0;
            airplane.GetComponent<Airplane>().enabled = false; 
            if(gameInputs.TouchInput.TouchPress.triggered)
            {
                StartTouch();
            }
        }
    }

    void StartTouch()
    {
        Time.timeScale = 1;
        Destroy(airplane, 7f);
        airplane.transform.DetachChildren();
        airplane.GetComponent<Airplane>().enabled = true;
        player.GetComponent<Move>().enabled = true;        
    }
}
