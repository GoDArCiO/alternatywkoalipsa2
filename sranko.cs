using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sranko : MonoBehaviour
{
    private Transform target;
    public GameObject gameObjects;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, target.position) < 5)
        {
            gameObjects.SetActive(true);
        }
        else
        {
            gameObjects.SetActive(false);
        }
    }
}
