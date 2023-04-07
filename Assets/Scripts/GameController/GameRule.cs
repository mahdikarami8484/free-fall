using System.Collections;
using UnityEngine;

public class GameRule : MonoBehaviour
{
    public GameObject groundObject;
    public float heightLevel = 100f;

    private Transform player;
    private Vector3 firstPosition;

    private Renderer renderer_groundObject;

    void Start()
    {
        player = GetComponent<GameController>().player.transform;
        firstPosition = player.position;
        groundObject = Instantiate(groundObject, new Vector3(0, player.position.y - heightLevel, 0), new Quaternion(0, 0, 0, 0));
        renderer_groundObject = groundObject.GetComponent<Renderer>();
    }

    void Update()
    {
        if(renderer_groundObject.isVisible)
        {
            GetComponent<CreateObject>().enabled = false;
            StartCoroutine(StopCamera());
        }
    }

    IEnumerator StopCamera()
    {
        yield return new WaitForSeconds(2f/player.GetComponent<Move>().fallSpeed);
        Camera.main.gameObject.GetComponent<follow>().enabled = false;
    }
}
