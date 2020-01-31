using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zablokuj : MonoBehaviour
{
    public GameObject bleed;
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            bleed.GetComponent<sciekinamiasto>().zblokuj();
        }
    }
}
