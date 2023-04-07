using UnityEngine;

public class follow : MonoBehaviour
{
    [Tooltip("gameObject target for follow")]
    public GameObject target;

    private float startPositionY;

    void Start()
    {
        startPositionY = target.transform.position.y;
    }

    void LateUpdate()
    {
        transform.position = new Vector3(transform.position.x, target.transform.position.y - startPositionY, transform.position.z);
    }
}
