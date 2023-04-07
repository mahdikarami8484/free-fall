using UnityEngine;

public class Airplane : MonoBehaviour
{
    void Update()
    {
        transform.position += transform.right * 3f * Time.deltaTime;
    }
}
