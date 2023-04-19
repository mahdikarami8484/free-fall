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
        if (SystemInfo.supportsGyroscope)
		{
			Input.gyro.enabled = true;
			Input.gyro.updateInterval = 0.0167f;
		}
    }

    void OnEnable()
    {
        gameInputs.Enable();
    }

    void Update()
    {
        Fall();
        moveAndroid();
        movePc();
    }

	void Fall()
	{
        transform.position += -transform.up * Mathf.Clamp(fallSpeed, 0f, fallSpeed + 50f) * Time.deltaTime;
	}

    void movePc()
    {
        float horizontal = gameInputs.PlayerInput.Horizontal.ReadValue<float>();
        transform.position += transform.right * moveSpeed * horizontal * Time.deltaTime;
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -2.21f, 2.21f), transform.position.y, transform.position.z); 
    }


    void moveAndroid()
    {
        float xMovement = Input.gyro.rotationRate.y * Time.deltaTime * moveSpeed;
        Vector3 movement = new Vector3(Mathf.Clamp(xMovement, -2.21f, 2.21f), 0, 0);
        transform.Translate(movement);	
    }
    
}
