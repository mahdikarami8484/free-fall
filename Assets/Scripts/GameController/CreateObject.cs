using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random=UnityEngine.Random;

public class CreateObject : MonoBehaviour
{

    [Tooltip("objects for rand spawn")]
    public List<GameObject> objects;

    public int numberObject;

    [Tooltip("Player gameObject")]
    public GameObject player;

    private List<GameObject> disableObject = new List<GameObject>();

    private float playerSpeed;

    void Start()
    {

        playerSpeed = player.GetComponent<Move>().fallSpeed;

        for(int i = 0; i < numberObject; i++)
        {
            //GameObject gameobject = Instantiate(objects[Random.Range(0, objects.Count)], new Vector3(Random.Range(-2.21f, 2.21f), player.transform.position.y - Random.Range(8f, 15f), 0f), new Quaternion(0, 0, 0, 0));               
            GameObject gameObject = Instantiate(objects[Random.Range(0, objects.Count)], Vector3.zero, new Quaternion(0f, 0f, 0f, 0f));
            gameObject.SetActive(false);
            disableObject.Add(gameObject);
        }

        StartCoroutine(Create());
    }

    IEnumerator Create()
    {
        int gameObject = Random.Range(0, disableObject.Count-1);
        if(!disableObject[gameObject].GetComponent<Renderer>().isVisible)
        {
            disableObject[gameObject].transform.position = new Vector3(Random.Range(-2.21f, 2.21f), player.transform.position.y - Random.Range(9f, 15f), 0f);
            disableObject[gameObject].SetActive(true);
            StartCoroutine(DisableObject(gameObject));
        }else
        {
            StartCoroutine(Create());    
        }
        yield return new WaitForSeconds(Random.Range(2f/playerSpeed, 2f/playerSpeed + 1.5f));
        StartCoroutine(Create());
    }

    IEnumerator DisableObject(int gameObject)
    {
        yield return new WaitForSeconds(10f);
        if(disableObject[gameObject].GetComponent<Renderer>().isVisible)
        {
            yield return new WaitForSeconds(2f);
        }
        disableObject[gameObject].SetActive(false);
    }
}