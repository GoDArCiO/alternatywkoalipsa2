using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makebossslider : MonoBehaviour
{
    public GameObject na;
    public int blok = 0;

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Player") && blok == 0)
        {

            na.SetActive(true);
            blok = 1;
        }
    }
}
