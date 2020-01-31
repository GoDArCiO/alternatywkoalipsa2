using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class patroliren : MonoBehaviour
{

    public float speed;
    private float waitTime;
    public float setWaitTime;

    private Transform target;

    public Transform[] moveSpots;
    private int randomSpot;



    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AIDestinationSetter>().enabled = false;
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        waitTime = setWaitTime;
        randomSpot = Random.Range(0, moveSpots.Length);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, moveSpots[randomSpot].position, speed * Time.deltaTime);

        if (Vector2.Distance(transform.position, target.position) < 8)
        {
            GetComponent<AIDestinationSetter>().enabled = true;
            GetComponent<patroliren>().enabled = false;
        }

        if (Vector2.Distance(transform.position, moveSpots[randomSpot].position) < 0.5f)
        {
            if (waitTime <= 0)
            {
                randomSpot = Random.Range(0, moveSpots.Length);
                waitTime = setWaitTime;
            }
            else
            {
                waitTime -= Time.deltaTime;
            }
        }
    }
}
