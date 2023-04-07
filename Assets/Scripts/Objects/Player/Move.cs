using UnityEngine;
using UnityEngine.InputSystem;

public class Move : MonoBehaviour
{

    [Tooltip("fall speed player")]
    public float fallSpeed = 10f;
    
    [Tooltip("move speed player")]
    public float moveSpeed = 10f;

    private GameInputs gameInputs;

    void Awake()
    {
        gameInputs = new GameInputs();
    }

    void OnEnable()
    {
        gameInputs.Enable();
    }

    void Update()
    {
        Fall();
        move();
    }

	void Fall()
	{
        transform.position += -transform.up * Mathf.Clamp(fallSpeed, 0f, fallSpeed + 50f) * Time.deltaTime;
	}

    void move()
    {
        float horizontal = gameInputs.PlayerInput.Horizontal.ReadValue<float>();
        transform.position += transform.right * moveSpeed * horizontal * Time.deltaTime;
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -2.21f, 2.21f), transform.position.y, transform.position.z); 
    }

    
}
