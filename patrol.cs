using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patrol : MonoBehaviour
{
    public float speed;
    public Transform[] moveSpots;
    public int blokuj=0;
    // Update is called once per frame
    void Update()
    {
        if (blokuj == 0)
        {
            transform.position = Vector2.MoveTowards(transform.position, moveSpots[0].position, speed * Time.deltaTime);
        }
        if (blokuj == 1)
        {
            transform.position = Vector2.MoveTowards(transform.position, moveSpots[1].position, speed * Time.deltaTime);
        }
        if (Vector2.Distance(transform.position, moveSpots[0].position) < 0.2f)
        {
            blokuj = 1;
        }
        if (Vector2.Distance(transform.position, moveSpots[1].position) < 0.2f)
        {
            blokuj = 0;
        }
    }
}
